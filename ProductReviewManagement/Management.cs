﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagement
{
    public class Management
    {
        public readonly DataTable dataTable = new DataTable();

        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                orderby productReviews.Rating descending
                                select productReviews).Take(3);

            foreach (var list in recordedData)
            {
                Console.WriteLine("Product ID : " + list.ProductID + " User ID : " + list.UserID + " Rating : " + list.Rating + " Review : " + list.Review + " isLike : " + list.isLike);
            }
        }

        public void SelectedRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                where (productReviews.ProductID == 1 || productReviews.ProductID == 4 || productReviews.ProductID == 9)
                                && productReviews.Rating > 3
                                select productReviews);

            foreach (var list in recordedData)
            {
                Console.WriteLine("Product ID : " + list.ProductID + " User ID : " + list.UserID + " Rating : " + list.Rating + " Review : " + list.Review + " isLike : " + list.isLike);
            }
        }

        public void RetrieveCountOfReviews(List<ProductReview> listProductReview)
        {
            var recordedData = listProductReview.GroupBy(x => x.Review).Select(x => new { Review = x.Key, Count = x.Count() });

            foreach (var list in recordedData)
            {
                Console.WriteLine("Review : " + list.Review + " ------- " + "Count : " + list.Count);
            }
        }

        public void RetrieveProductIdAndRatingOfRecords(List<ProductReview> listProductReview, int ProductID)
        {
            var recordedData = listProductReview.Select(x => new { ProductID = x.ProductID, Review = x.Review }).Where(x => x.ProductID == ProductID);
            foreach (var list in recordedData)
            {
                Console.WriteLine("Product ID : " + list.ProductID + " ------- " + "Review : " + list.Review);
            }
        }

        public void BottomRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                orderby productReviews.Rating descending
                                select productReviews).Skip(5);

            foreach (var list in recordedData)
            {
                Console.WriteLine("Product ID : " + list.ProductID + " User ID : " + list.UserID + " Rating : " + list.Rating + " Review : " + list.Review + " isLike : " + list.isLike);
            }
        }

        public void isLikeRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                where productReviews.isLike == true
                                select productReviews);

            foreach (var list in recordedData)
            {
                Console.WriteLine("Product ID : " + list.ProductID + " User ID : " + list.UserID + " Rating : " + list.Rating + " Review : " + list.Review + " isLike : " + list.isLike);
            }
        }

        public void AverageRatingOfProductID(List<ProductReview> listProductReview)
        {
            var recordedData = listProductReview.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, AverageRating = x.Average(y => y.Rating) });

            foreach (var list in recordedData)
            {
                Console.WriteLine("Product ID : " + list.ProductID + " ------- " + "Count : " + list.AverageRating);
            }
        }

        public void RecordsWithNiceReview(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                where productReviews.Review == "Nice"
                                select productReviews);

            foreach (var list in recordedData)
            {
                Console.WriteLine("Product ID : " + list.ProductID + " User ID : " + list.UserID + " Rating : " + list.Rating + " Review : " + list.Review + " isLike : " + list.isLike);
            }
        }
    }
}
