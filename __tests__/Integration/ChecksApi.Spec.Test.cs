/*
 * Lob
 *
 * The Lob API is organized around REST. Our API is designed to have predictable, resource-oriented URLs and uses HTTP response codes to indicate any API errors. <p> Looking for our [previous documentation](https://lob.github.io/legacy-docs/)?
 *
 * The version of the OpenAPI document: 1.3.0
 * Contact: lob-openapi@lob.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using lob.dotnet.Client;
using lob.dotnet.Api;
using lob.dotnet.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace __tests__.Integration {
    [TestFixture]
    [Parallelizable(scope: ParallelScope.Self)]
    public class ChecksApiTests : IDisposable
    {
        private ChecksApi validApi;
        private ChecksApi invalidApi;
        private CheckEditable checkEditable;
        private List<string> idsToDelete;

        private Address address1;
        private Address address2;
        private AddressesApi validAddressesApi;
        private BankAccount bankAccount;
        private BankAccountsApi validBankAccountsApi;

        public ChecksApiTests()
        {
            Configuration config = new Configuration();
            Configuration invalidConfig = new Configuration();

            DotNetEnv.Env.TraversePath().Load();
            config.Username = System.Environment.GetEnvironmentVariable("LOB_API_TEST_KEY");
            invalidConfig.Username = "fake api key";

            validApi = new ChecksApi(config);
            invalidApi = new ChecksApi(invalidConfig);

            BankAccountWritable bankAccountWritable = new BankAccountWritable(
                "Test Bank Account", // description
                "322271627", // routingNumber
                "123456789", // accountNumber
                BankTypeEnum.Individual, // accountType
                "Sinead Connor", // signatory
                null // metadata
            );

            validBankAccountsApi = new BankAccountsApi(config);
            bankAccount = validBankAccountsApi.BankAccountCreate(bankAccountWritable);

            List<int> amounts = new List<int>();
            amounts.Add(11);
            amounts.Add(35);

            BankAccountVerify verification = new BankAccountVerify(amounts);
            validBankAccountsApi.BankAccountVerify(bankAccount.Id, verification);

            AddressEditable addressEditable1 = new AddressEditable(
                "1313 CEMETERY LN", // addressLine1
                null, // addressLine2
                "WESTFIELD", // addressCity
                "NJ", // addressState
                "07000", // addressZip
                CountryExtended.US, // addressCountry
                "test description", // description
                "Thing T. Thing", // name
                null, // company
                null, // phone
                null, // email
                null // metadata
            );

            AddressEditable addressEditable2 = new AddressEditable(
                "001 CEMETERY LN", // addressLine1
                "SUITE 666", // addressLine2
                "WESTFIELD", // addressCity
                "NJ", // addressState
                "07000", // addressZip
                CountryExtended.US, // addressCountry
                null, // description
                "FESTER", // name
                null, // company
                null, // phone
                null, // email
                null // metadata
            );

            validAddressesApi = new AddressesApi(config);
            address1 = validAddressesApi.AddressCreate(addressEditable1);
            address2 = validAddressesApi.AddressCreate(addressEditable2);

            checkEditable = new CheckEditable(
                address1.Id, // from
                address2.Id, // to
                bankAccount.Id, // bankAccount
                100, // amount
                null, // logo
                null, // checkBottom
                null, // attachment
                "check 1" // description
            );

            idsToDelete = new List<string>();
        }

        public void Dispose()
        {
            validBankAccountsApi.BankAccountDelete(bankAccount.Id);
            validAddressesApi.AddressDelete(address1.Id);
            validAddressesApi.AddressDelete(address2.Id);
            idsToDelete.ForEach(id => validApi.CheckCancel(id));
        }

        [Test]
        public void CheckCreateTest() {
            Check response = validApi.CheckCreate(checkEditable);

            Assert.NotNull(response.Id);
            idsToDelete.Add(response.Id);
            Assert.AreEqual(response.Description, checkEditable.Description);
        }

        [Test]
        public void CheckCreateTestBadParameter() {
            try {
                Check response = validApi.CheckCreate(null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Missing required parameter 'checkEditable'"));
            }
        }

        [Test]
        public void CheckCreateTestBadUsername() {
            try {
                Check response = invalidApi.CheckCreate(checkEditable);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Your API key is not valid"));
            }
        }

        [Test]
        public void CheckRetrieveTest() {
            Check check = validApi.CheckCreate(checkEditable);
            idsToDelete.Add(check.Id);
            Check response = validApi.CheckRetrieve(check.Id);

            Assert.NotNull(response.Id);
            Assert.AreEqual(response.Id, check.Id);
        }

        [Test]
        public void CheckRetrieveTestBadParameter() {
            try {
                Check response = validApi.CheckRetrieve(null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Missing required parameter 'chkId'"));
            }
        }

        [Test]
        public void CheckRetrieveTestBadUsername() {
            Check check = validApi.CheckCreate(checkEditable);
            idsToDelete.Add(check.Id);
            try {
                Check response = invalidApi.CheckRetrieve(check.Id);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.That(e.Message, Does.Contain("Your API key is not valid"));
            }
        }

        [Test]
        public void CheckListTest() {
            CheckList response = validApi.ChecksList(null, null, null, null, null, null, null, null, null, null);

            Assert.Greater(response.Count, 0);
        }

        [Test]
        public void CheckListTestWithLimitParameter() {
            int limit = 2;
            CheckList response = validApi.ChecksList(limit, null, null, null, null, null, null, null, null, null);

            Assert.AreEqual(response.Count, 2);
        }

        [Test]
        public void CheckListTestWithIncludeParameter() {
            List<string> includeList = new List<string>();
            includeList.Add("total_count");

            CheckList response = validApi.ChecksList(null, null, null, includeList);
            Assert.Greater(response.Count, 0);
            Assert.NotNull(response.TotalCount);
        }

        /* TODO:  [DXP-1028] fix unpacking dictionaries into query params
        [Test]
        public void CheckListTestWithDateCreatedParameter() {
            Dictionary<String, String> dateCreated = new Dictionary<String, String>();
            dateCreated.Add("gt", "2020-01-01");
            dateCreated.Add("lt", "2020-01-31T12");

            CheckList response = validApi.ChecksList(null, null, null, null, dateCreated);
            Console.WriteLine(response);
            Assert.Greater(response.Count, 0);
        }
        */

        [Test]
        public void CheckListTestWithMetadataParameter() {
            Dictionary<String, String> metadata = new Dictionary<String, String>();
            metadata.Add("name", "Harry");

            CheckList response = validApi.ChecksList(null, null, null, null, null, metadata);
            Assert.Greater(response.Count, 0);
        }

        [Test]
        public void CheckListTestWithScheduledParameter() {
            Boolean scheduled = true;

            CheckList response = validApi.ChecksList(null, null, null, null, null, null, scheduled);
            Assert.Greater(response.Count, 0);
        }

        /* TODO: [DXP-1028]
        [Test]
        public void CheckListTestWithSendDateParameter() {
            Dictionary<String, String> sendDate = new Dictionary<String, String>();
            sendDate.Add("gt", "2020-01-01");
            sendDate.Add("lt", "2020-01-31T12");

            CheckList response = validApi.ChecksList(null, null, null, null, null, null, null, sendDate);
            Assert.Greater(response.Count, 0);
        }
        */

        [Test]
        public void CheckListTestWithMailTypeParameter() {
            MailType mailType = MailType.FirstClass;

            CheckList response = validApi.ChecksList(null, null, null, null, null, null, null, null, mailType);
            Assert.GreaterOrEqual(response.Count, 0);
        }

        [Test]
        public void CheckListTestWithSortByParameter() {
            SortBy5 sortBy = new SortBy5(null, SortBy5.SendDateEnum.Asc);
            CheckList response = validApi.ChecksList(null, null, null, null, null, null, null, null, null, sortBy);
            Assert.Greater(response.Count, 0);
        }
    }
}