// See https://aka.ms/new-console-template for more information


using System;
using System.Linq;
using System.Collections.Generic;

namespace ProductReviewManagementWithLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management problem statement");

            //UC-1
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductID=1,UserID=1,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductID=2,UserID=1,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ProductID=3,UserID=3,Rating=3,Review="nice",isLike=true},
                new ProductReview(){ProductID=4,UserID=2,Rating=4,Review="nice",isLike=false},
                new ProductReview(){ProductID=5,UserID=1,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductID=6,UserID=1,Rating=1,Review="Bad",isLike=false},
                new ProductReview(){ProductID=7,UserID=6,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductID=3,UserID=4,Rating=4,Review="nice",isLike=true},
                new ProductReview(){ProductID=9,UserID=6,Rating=2,Review="Bad",isLike=false},
                new ProductReview(){ProductID=10,UserID=2,Rating=1,Review="Bad",isLike=false},
                new ProductReview(){ProductID=11,UserID=10,Rating=4,Review="nice",isLike=false},
                new ProductReview(){ProductID=12,UserID=10,Rating=3,Review="nice",isLike=true},
                new ProductReview(){ProductID=4,UserID=7,Rating=10,Review="Bad",isLike=false},
                new ProductReview(){ProductID=14,UserID=4,Rating=7,Review="Bad",isLike=false},
                new ProductReview(){ProductID=15,UserID=10,Rating=9,Review="Good",isLike=true},
                new ProductReview(){ProductID=16,UserID=8,Rating=3,Review="nice",isLike=true},
                new ProductReview(){ProductID=17,UserID=2,Rating=3,Review="nice",isLike=false},
                new ProductReview(){ProductID=20,UserID=3,Rating=2,Review="Bad",isLike=false},
                new ProductReview(){ProductID=20,UserID=10,Rating=1,Review="Bad",isLike=false},
                new ProductReview(){ProductID=20,UserID=10,Rating=5,Review="Good",isLike=true}
            };
            /*foreach (var list in productReviewList)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID + " " + "Ratins:-" + list.Rating + " " +
                    "Review:-" + list.Review + " " + "isLike:-" + list.isLike);
            }*/

            //UC-2
            Management management = new Management();
            management.Top3Records(productReviewList);

            //UC-3
            //management.SelectedRecords(productReviewList);

            //UC-4
            //management.RetrieveCountOfRecords(productReviewList);

            //UC-5
            //management.RetriveproductIDAndReview(productReviewList);

            //UC-6
            //management.SkipTop5Records(productReviewList);

            //UC-7
            //management.UsingSelectLINQ_retriveProductIDAndReview(productReviewList);

            //UC-8
            //management.createDatatable_Using_Csharp(productReviewList);

            //UC-9
            //management.RetriveRecordsWhose_islike_True(productReviewList);

            //UC-10
            //management.AvgOfProductID(productReviewList);

            //UC-11
            //management.RetreiveRecordsWhose_Review_nice(productReviewList);

            //UC12
            //management.RetreiveRecordsWhose_UserID_10(productReviewList);
        }
    }
}