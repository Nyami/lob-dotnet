/*
 * Lob
 *
 * The Lob API is organized around REST. Our API is designed to have predictable, resource-oriented URLs and uses HTTP response codes to indicate any API errors. <p> Looking for our [previous documentation](https://lob.github.io/legacy-docs/)?
 *
 * The version of the OpenAPI document: 1.3.0
 * Contact: lob-openapi@lob.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using NUnit.Framework;

using Moq;

using lob.dotnet.Client;
using lob.dotnet.Api;
using lob.dotnet.Model;

namespace __tests__.Api
{
    /// <summary>
    ///  Class for testing PostcardsApi
    /// </summary>
    [TestFixture]
    public class PostcardsApiTests : IDisposable
    {
        private Mock<IPostcardsApi> PostcardsApiMock;
        private PostcardList fakePostcardList;

        public PostcardsApiTests()
        {
            PostcardsApiMock = new Mock<IPostcardsApi>();

            List<Postcard> listOfPostcards = new List<Postcard>();
            Postcard data1 = new Postcard();
            Postcard data2 = new Postcard();

            data1.Id = "psc_fakeId1";
            data2.Id = "psc_fakeId2";
            listOfPostcards.Add(data1);
            listOfPostcards.Add(data2);

            fakePostcardList = new PostcardList();

            fakePostcardList.Data = listOfPostcards;
            fakePostcardList.Object = "list";
            fakePostcardList.Count = listOfPostcards.Count;
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test PostcardCreate
        /// </summary>
        [Test]
        public void PostcardCreateTest()
        {
            Postcard fakePostcard = new Postcard();
            fakePostcard.Id = "psc_fakeId";

            PostcardEditable postcardEditable = new PostcardEditable(
                "adr_fakeId", // to
                "adr_fakeId", // from
                default(PostcardSize), // size
                "C# unit test postcard", // description
                default(Dictionary<string, string>), // metadata
                default(MailType), // mailType
                default(Object), // mergeVariables
                default(DateTime), // sendDate
                "https://s3-us-west-2.amazonaws.com/public.lob.com/assets/templates/4x6_pc_template.pdf", // front
                "https://s3-us-west-2.amazonaws.com/public.lob.com/assets/templates/4x6_pc_template.pdf", // back
                default(string) // billingGroupId
            );

            PostcardsApiMock.Setup(x => x.PostcardCreate(postcardEditable, null, It.IsAny<int>())).Returns(fakePostcard);
            Postcard response = PostcardsApiMock.Object.PostcardCreate(postcardEditable);

            Assert.IsInstanceOf<Postcard>(response);
            Assert.AreEqual(response.Id, "psc_fakeId");
        }

        /// <summary>
        /// Test PostcardCreateHandlesException
        /// </summary>
        [Test]
        public void PostcardCreateTestHandlesException()
        {
            Postcard fakePostcard = new Postcard();
            ApiException fakeException = new ApiException(
                402,
                "This is an error"
            );

            PostcardsApiMock.Setup(x => x.PostcardCreate(null, null, It.IsAny<int>())).Throws(fakeException);
            try {
                Postcard response = PostcardsApiMock.Object.PostcardCreate(null, null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.AreEqual(e.Message, fakeException.Message);
            }
        }

        /// <summary>
        /// Test PostcardDelete
        /// </summary>
        [Test]
        public void PostcardDeleteTest()
        {
            PostcardDeletion fakePostcard = new PostcardDeletion();

            fakePostcard.Id = "psc_fakeId";
            fakePostcard.Deleted = true;

            PostcardsApiMock.Setup(x => x.PostcardDelete(fakePostcard.Id, It.IsAny<int>())).Returns(fakePostcard);

            var response = PostcardsApiMock.Object.PostcardDelete(fakePostcard.Id);

            Assert.IsInstanceOf<PostcardDeletion>(response);
            Assert.AreEqual(response.Deleted, fakePostcard.Deleted);
            Assert.AreEqual(response.Id, fakePostcard.Id);
        }

        /// <summary>
        /// Test PostcardDeleteHandlesException
        /// </summary>
        [Test]
        public void PostcardDeleteHandlesException()
        {
            ApiException fakeException = new ApiException(
                402,
                "This is an error"
            );

            PostcardsApiMock.Setup(x => x.PostcardDelete(null, It.IsAny<int>())).Throws(fakeException);
            try {
                var response = PostcardsApiMock.Object.PostcardDelete(null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.AreEqual(e.Message, fakeException.Message);
            }
        }

        /// <summary>
        /// Test PostcardRetrieve
        /// </summary>
        [Test]
        public void PostcardRetrieveTest()
        {
            Postcard fakePostcard = new Postcard();

            fakePostcard.Id = "psc_fakeId";
            PostcardsApiMock.Setup(x => x.PostcardRetrieve(fakePostcard.Id, It.IsAny<int>())).Returns(fakePostcard);
            Postcard response = PostcardsApiMock.Object.PostcardRetrieve(fakePostcard.Id);

            Assert.IsInstanceOf<Postcard>(response);
            Assert.AreEqual(response.Id, fakePostcard.Id);
        }

        /// <summary>
        /// Test PostcardRetrieveHandlesException
        /// </summary>
        [Test]
        public void PostcardRetrieveTestHandlesException()
        {
            ApiException fakeException = new ApiException(
                402,
                "This is an error"
            );
            PostcardsApiMock.Setup(x => x.PostcardRetrieve(null, It.IsAny<int>())).Throws(fakeException);

            try {
                var response = PostcardsApiMock.Object.PostcardRetrieve(null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.AreEqual(e.Message, fakeException.Message);
            }
        }

        /// <summary>
        /// Test PostcardList
        /// </summary>
        [Test]
        public void PostcardListTest()
        {
            PostcardsApiMock.Setup(x => x.PostcardsList(null, null, null, null, null, null, null, null, null, null, null, It.IsAny<int>())).Returns(fakePostcardList);

            var response = PostcardsApiMock.Object.PostcardsList(null, null, null, null, null, null, null, null, null, null, null);

            Assert.IsInstanceOf<PostcardList>(response);
            Assert.AreEqual(response.Count, fakePostcardList.Count);
        }

        /// <summary>
        /// Test PostcardListHandlesException
        /// </summary>
        [Test]
        public void PostcardListTestHandlesException()
        {
            ApiException fakeException = new ApiException(
                402,
                "This is an error"
            );
            PostcardsApiMock.Setup(x => x.PostcardsList(null, null, null, null, null, null, null, null, null, null, null, It.IsAny<int>())).Throws(fakeException);

            try {
                var response = PostcardsApiMock.Object.PostcardsList(null, null, null, null, null, null, null, null, null, null, null);
            }
            catch (Exception e) {
                Assert.IsInstanceOf<ApiException>(e);
                Assert.AreEqual(e.Message, fakeException.Message);
            }
        }

        /// <summary>
        /// Test PostcardListWithLimitParam
        /// </summary>
        [Test]
        public void PostcardListTestWithLimitParam()
        {
            int limit = 2;

            PostcardsApiMock.Setup(x => x.PostcardsList(limit, null, null, null, null, null, null, null, null, null, null, It.IsAny<int>())).Returns(fakePostcardList);

            var response = PostcardsApiMock.Object.PostcardsList(limit, null, null, null, null, null, null, null, null, null, null);

            Assert.IsInstanceOf<PostcardList>(response);
            Assert.AreEqual(response.Count, fakePostcardList.Count);
        }

        /// <summary>
        /// Test PostcardListWithBeforeParam
        /// </summary>
        [Test]
        public void PostcardListTestWithBeforeParam()
        {
            string before = "before";

            PostcardsApiMock.Setup(x => x.PostcardsList(null, before, null, null, null, null, null, null, null, null, null, It.IsAny<int>())).Returns(fakePostcardList);

            var response = PostcardsApiMock.Object.PostcardsList(null, before, null, null, null, null, null, null, null, null, null);

            Assert.IsInstanceOf<PostcardList>(response);
            Assert.AreEqual(response.Count, fakePostcardList.Count);
        }

        /// <summary>
        /// Test PostcardListWithAfterParam
        /// </summary>
        [Test]
        public void PostcardListTestWithAfterParam()
        {
            string after = "after";

            PostcardsApiMock.Setup(x => x.PostcardsList(null, null, after, null, null, null, null, null, null, null, null, It.IsAny<int>())).Returns(fakePostcardList);

            var response = PostcardsApiMock.Object.PostcardsList(null, null, after, null, null, null, null, null, null, null, null);

            Assert.IsInstanceOf<PostcardList>(response);
            Assert.AreEqual(response.Count, fakePostcardList.Count);
        }

        /// <summary>
        /// Test PostcardListWithIncludeParam
        /// </summary>
        [Test]
        public void PostcardListTestWithIncludeParam()
        {
            List<string> include = new List<string>();
            include.Add("total_count");

            PostcardsApiMock.Setup(x => x.PostcardsList(null, null, null, include, null, null, null, null, null, null, null, It.IsAny<int>())).Returns(fakePostcardList);

            var response = PostcardsApiMock.Object.PostcardsList(null, null, null, include, null, null, null, null, null, null, null);

            Assert.IsInstanceOf<PostcardList>(response);
            Assert.AreEqual(response.Count, fakePostcardList.Count);
        }

        /// <summary>
        /// Test PostcardListWithDateCreatedParam
        /// </summary>
        [Test]
        public void PostcardListTestWithDateCreatedParam()
        {
            Dictionary<String, String> dateCreated = new Dictionary<String, String>();
            dateCreated.Add("gt", "2020-01-01");
            dateCreated.Add("lt", "2020-01-31T12");

            PostcardsApiMock.Setup(x => x.PostcardsList(null, null, null, null, dateCreated, null, null, null, null, null, null, It.IsAny<int>())).Returns(fakePostcardList);

            var response = PostcardsApiMock.Object.PostcardsList(null, null, null, null, dateCreated, null, null, null, null, null, null);

            Assert.IsInstanceOf<PostcardList>(response);
            Assert.AreEqual(response.Count, fakePostcardList.Count);
        }

        /// <summary>
        /// Test PostcardListWithMetadataParam
        /// </summary>
        [Test]
        public void PostcardListTestWithMetadataParam()
        {
            Dictionary<String, String> metadata = new Dictionary<String, String>();
            metadata.Add("name", "Harry");

            PostcardsApiMock.Setup(x => x.PostcardsList(null, null, null, null, null, metadata, null, null, null, null, null, It.IsAny<int>())).Returns(fakePostcardList);

            var response = PostcardsApiMock.Object.PostcardsList(null, null, null, null, null, metadata, null, null, null, null, null);

            Assert.IsInstanceOf<PostcardList>(response);
            Assert.AreEqual(response.Count, fakePostcardList.Count);
        }

        /// <summary>
        /// Test PostcardListWithSizeParam
        /// </summary>
        [Test]
        public void PostcardListTestWithSizeParam()
        {
            PostcardSize size = PostcardSize._4x6;

            PostcardsApiMock.Setup(x => x.PostcardsList(null, null, null, null, null, null, size, null, null, null, null, It.IsAny<int>())).Returns(fakePostcardList);

            var response = PostcardsApiMock.Object.PostcardsList(null, null, null, null, null, null, size, null, null, null, null);

            Assert.IsInstanceOf<PostcardList>(response);
            Assert.AreEqual(response.Count, fakePostcardList.Count);
        }

        /// <summary>
        /// Test PostcardListWithScheduledParam
        /// </summary>
        [Test]
        public void PostcardListTestWithScheduledParam()
        {
            Boolean scheduled = true;

            PostcardsApiMock.Setup(x => x.PostcardsList(null, null, null, null, null, null, null, scheduled, null, null, null, It.IsAny<int>())).Returns(fakePostcardList);

            var response = PostcardsApiMock.Object.PostcardsList(null, null, null, null, null, null, null, scheduled, null, null, null);

            Assert.IsInstanceOf<PostcardList>(response);
            Assert.AreEqual(response.Count, fakePostcardList.Count);
        }

        /// <summary>
        /// Test PostcardListWithSendDateParam
        /// </summary>
        [Test]
        public void PostcardListTestWithSendDateParam()
        {
            Dictionary<String, String> sendDate = new Dictionary<String, String>();
            sendDate.Add("gt", "2020-01-01");
            sendDate.Add("lt", "2020-01-31T12");

            PostcardsApiMock.Setup(x => x.PostcardsList(null, null, null, null, null, null, null, null, sendDate, null, null, It.IsAny<int>())).Returns(fakePostcardList);

            var response = PostcardsApiMock.Object.PostcardsList(null, null, null, null, null, null, null, null, sendDate, null, null);

            Assert.IsInstanceOf<PostcardList>(response);
            Assert.AreEqual(response.Count, fakePostcardList.Count);
        }

        /// <summary>
        /// Test PostcardListWithMailTypeParam
        /// </summary>
        [Test]
        public void PostcardListTestWithMailTypeParam()
        {
            MailType mailType = MailType.FirstClass;

            PostcardsApiMock.Setup(x => x.PostcardsList(null, null, null, null, null, null, null, null, null, mailType, null, It.IsAny<int>())).Returns(fakePostcardList);

            var response = PostcardsApiMock.Object.PostcardsList(null, null, null, null, null, null, null, null, null, mailType, null);

            Assert.IsInstanceOf<PostcardList>(response);
            Assert.AreEqual(response.Count, fakePostcardList.Count);
        }

        /// <summary>
        /// Test PostcardListWithSortByParam
        /// </summary>
        [Test]
        public void PostcardListTestWithSortByParam()
        {
            SortBy5 sortBy = new SortBy5(null, SortBy5.SendDateEnum.Asc);

            PostcardsApiMock.Setup(x => x.PostcardsList(null, null, null, null, null, null, null, null, null, null, sortBy, It.IsAny<int>())).Returns(fakePostcardList);

            var response = PostcardsApiMock.Object.PostcardsList(null, null, null, null, null, null, null, null, null, null, sortBy);

            Assert.IsInstanceOf<PostcardList>(response);
            Assert.AreEqual(response.Count, fakePostcardList.Count);
        }
    }
}