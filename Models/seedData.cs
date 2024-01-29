using CRUDstudent.Data;
using Microsoft.EntityFrameworkCore;

namespace CRUDstudent.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CRUDstudentContext(
                serviceProvider.GetRequiredService<DbContextOptions<CRUDstudentContext>>()))
            {
                // Look for any students.
                if (context.Student.Any())
                {
                    return;   // DB has been seeded
                }

                context.Student.AddRange(
                    new Student
                    {
                        Group = "Group1",
                        RollNumber = "123",
                        FullName = "John Doe",
                        Comment = "Good student",
                        Image = "path/to/image1.jpg"
                    },
                    new Student
                    {
                        Group = "Group2",
                        RollNumber = "456",
                        FullName = "Jane Smith",
                        Comment = "Average student",
                        Image = "path/to/image2.jpg"
                    },
                    new Student
                    {
                        Group = "Group3",
                        RollNumber = "789",
                        FullName = "Bob Johnson",
                        Comment = "Excellent student",
                        Image = "path/to/image3.jpg"
                    }
                );

                context.SaveChanges();
            }
        }
    }

}
