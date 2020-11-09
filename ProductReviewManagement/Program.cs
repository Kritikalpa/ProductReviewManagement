using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management");

            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductID = 1, UserID = 1, Rating=5, Review="Good",isLike = true},
                new ProductReview(){ProductID = 1, UserID = 1, Rating=4.7, Review="Good",isLike = true},
                new ProductReview(){ProductID = 1, UserID = 2, Rating=3, Review="Good",isLike = true},
                new ProductReview(){ProductID = 4, UserID = 3, Rating=4.9, Review="Good",isLike = true},
                new ProductReview(){ProductID = 5, UserID = 3, Rating=3, Review="Nice",isLike = true},
                new ProductReview(){ProductID = 4, UserID = 4, Rating=1, Review="Bad",isLike = false},
                new ProductReview(){ProductID = 1, UserID = 5, Rating=1, Review="Bad",isLike = false},
                new ProductReview(){ProductID = 6, UserID = 5, Rating=4, Review="Good",isLike = true},
                new ProductReview(){ProductID = 7, UserID = 5, Rating=3, Review="Good",isLike = true},
                new ProductReview(){ProductID = 9, UserID = 6, Rating=4.2, Review="Good",isLike = true},
                new ProductReview(){ProductID = 8, UserID = 7, Rating=4.4, Review="Good",isLike = true},
                new ProductReview(){ProductID = 6, UserID = 9, Rating=5, Review="Good",isLike = true},
                new ProductReview(){ProductID = 6, UserID = 10, Rating=2, Review="Bad",isLike = false}
            };

            foreach (var list in productReviewList)
            {
                Console.WriteLine("Product ID : " + list.ProductID + " User ID : " + list.UserID + " Rating : " + list.Rating + " Review : " + list.Rating + " isLike : " + list.isLike);
            }

            Management management = new Management();
            //UC2
            Console.WriteLine("\nUC2");
            management.TopRecords(productReviewList);
            //UC3
            Console.WriteLine("\nUC3");
            management.SelectedRecords(productReviewList);
        }
    }
}
