using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementWithLinq
{
    public class Management
    {
        public readonly DataTable dataTable = new DataTable();

        //UC-2
        public void Top3Records(List<ProductReview> productReviewList)
        {
            var recordedData = (from ProductReview in productReviewList
                                orderby ProductReview.Rating descending
                                select ProductReview).Take(3);

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID + " " + "Ratins:-" + list.Rating + " " +
                                    "Review:-" + list.Review + " " + "isLike:-" + list.isLike);
            }
        }

        //UC-3
        public void SelectedRecords(List<ProductReview> productReviewList)
        {
            var recordData = from ProductReview in productReviewList
                             where (ProductReview.ProductID == 1 || ProductReview.ProductID == 4 || ProductReview.ProductID == 9)
                             && ProductReview.Rating > 3
                             select ProductReview;
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID + " " + "Ratins:-" + list.Rating + " " +
                                    "Review:-" + list.Review + " " + "isLike:-" + list.isLike);
            }
        }

        //UC-4
        public void RetrieveCountOfRecords(List<ProductReview> productReviewList)
        {
            var recordedData = productReviewList.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductID + "------" + list.Count);
            }
        }

        //UC-5
        public void RetriveproductIDAndReview(List<ProductReview> productReviewList)
        {
            var recordedData = (from ProductReview in productReviewList
                                select new { ProductID = ProductReview.ProductID, Review = ProductReview.Review });
            Console.WriteLine("Product ID|Review");
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductID + "--->" + list.Review);
            }
        }

        //UC-6
        public void SkipTop5Records(List<ProductReview> productReviewList)
        {
            var data = (from productReview
                        in productReviewList
                        select productReview).Skip(5);
            Console.WriteLine("Records after skiping top 5.");
            foreach (var list in data)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "IsLike:-" + list.isLike);
            }
        }

        //UC-7
        public void UsingSelectLINQ_retriveProductIDAndReview(List<ProductReview> productReviewList)
        {
            var data = productReviewList.Select(Review => new { ProductID = Review.ProductID, Review = Review.Review });
            Console.WriteLine("Product ID|Review");
            foreach (var list in data)
            {
                Console.WriteLine(list.ProductID + "--->" + list.Review);
            }
        }

        //UC-8
        public void createDatatable_Using_Csharp(List<ProductReview> productReviewList)
        {
            DataTable result = new DataTable();
            result.Columns.Add("ProductID", typeof(Int32));
            result.Columns.Add("UserID", typeof(Int32));
            result.Columns.Add("Rating", typeof(Int32));
            result.Columns.Add("Review", typeof(string));
            result.Columns.Add("isLike", typeof(bool));
            foreach (var list in productReviewList)
            {
                result.Rows.Add(list.ProductID, list.UserID, list.Rating, list.Review, list.isLike);
            }
            Console.WriteLine("Records in DataTable.");
            foreach (var list in result.AsEnumerable())
            {
                Console.WriteLine("ProductID:- " + list.Field<int>("ProductID") + " " + "UserID:- " + list.Field<int>("UserID") +
                    " " + "Rating:- " + list.Field<int>("Rating") + " " + "Review:- " + list.Field<string>("Review") + " "
                    + "isLike:- " + list.Field<bool>("isLike"));
            }
        }

        //UC-9
        public void RetriveRecordsWhose_islike_True(List<ProductReview> productReviewList)
        {
            var recordedData = (from ProductReview in productReviewList
                                where (ProductReview.isLike == true)
                                select ProductReview);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID + " " + "Ratins:-" + list.Rating + " " +
                                    "Review:-" + list.Review + " " + "isLike:-" + list.isLike);
            }

        }

        //UC-10 ===========> GETTING ERROR RESOLVE IT 1ST

        public void AvgOfProductID(List<ProductReview> productReviewList)
        {
            foreach (var line in productReviewList.GroupBy(info => info.ProductID).Select(group => new
            {
                products = group.Key,
                Count = group.Average(a => a.Rating)
            }))

            {
                Console.WriteLine("Product Id:{0} => Average Rating :{1}", line.products, line.Count);
            }
        }


        //UC-11
        public void RetreiveRecordsWhose_Review_nice(List<ProductReview> productReviewList)
        {
            var recordedData = (from ProductReview in productReviewList
                                where (ProductReview.Review == "nice")
                                select ProductReview);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID + " " + "Ratins:-" + list.Rating + " " +
                                    "Review:-" + list.Review + " " + "isLike:-" + list.isLike);
            }
        }

        //UC-12

        public void RetreiveRecordsWhose_UserID_10(List<ProductReview> productReviewList)
        {
            var recordedData = (from ProductReview in productReviewList
                                where (ProductReview.UserID == 10)
                                orderby ProductReview.Rating ascending
                                select ProductReview);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID + " " + "Ratings:-" + list.Rating + " " +
                                    "Review:-" + list.Review + " " + "isLike:-" + list.isLike);
            }
        }


    }
}
