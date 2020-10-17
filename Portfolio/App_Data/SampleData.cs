using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.App_Data
{
    public class SampleData
    {
        public static void Initialize(PortfolioContext context)
        {
            if (!context.Works.Any())
            {
                context.Works.AddRange
                (
                    new Work
                    {
                        desc_short = "Banner for up2date",
                        desc_long = "",
                        tools = "Adobe Photoshop"
                    },                    
                    new Work
                    {
                        desc_short = "Banner for RomanD",
                        desc_long = "",
                        tools = "Adobe XD"
                    }
                );
                context.SaveChanges();
            }
            if (!context.Orders.Any())
            {
                context.Orders.AddRange
                (
                    new Order
                    {
                        user_name = "test",
                        contact_email = "test@gmail.com"
                    }
                ); 
                context.SaveChanges();
            }
            if (!context.Comments.Any())
            {
                context.Comments.AddRange
                (
                    new Comment
                    {
                        user_name = "test",
                        contact_email = "test@gmail.com",
                        feedback = "nice work"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
