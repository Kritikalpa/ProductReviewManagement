using System;
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
    }
}
