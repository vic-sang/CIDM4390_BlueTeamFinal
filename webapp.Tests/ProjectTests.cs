using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xunit;
using WebApp1.Data;
using WebApp1.Models;

namespace webapp.Tests;

public class ProjectTests
{
        [Fact]
        public async Task AddProgramAdminAsync_ProgramAdminIsAdded()
        {
            using (var db = new ApbetProjectContext(Utilities.TestDbContextOptions()))
            {
                // Arrange
                var recId = 10;
                var expectedProgramAdmin = new ProgramAdmin() 
                { 
                    Id = recId, 
                    FirstName = "Tester",
                    LastName = "Test",
                };

                // Act
                await db.AddProgramAdminAsync(expectedProgramAdmin);

                // Assert
                var actualProgramAdmin = await db.FindAsync<ProgramAdmin>(recId);
                Assert.Equal(expectedProgramAdmin, actualProgramAdmin);
            }
        }

        [Fact]
        public async Task SubmitForm()
        {
            using (var db = new ApbetProjectContext(Utilities.TestDbContextOptions()))
            {
                
                var expectedFormSubmission = new FormSubmission();
                bool result = expectedFormSubmission(0);

                
                Assert.False(result, "Form was not Submitted");
            }
        }

        [Fact]
        public async Task InstructorAuthenticated()
        {
            using (var db = new ApbetProjectContext(Utilities.TestDbContextOptions()))
            {
                var InstrucID =10;
                var expectedInstructor = new Instructor()
                {
                    InstructorID = InstrucID,
                    FirstName = "Testing",
                    LastName = "StillTesting",

                    
                };

                await db.AddInstructorAsync(expectedInstructor);
                Assert.

                var actualInstructor = await db.FindAsync<Instructor>(InstrucID);
                Assert.Equal(expectedInstructor, actualInstructor);
            }
        }
        // public bool InstructorAuthenticated(bool AuthenticatedInstructor)
        // {
        //     var InstrucID=10;
        //     if (InstructorAuthentication = 0)
        //     {
        //         return False;
        //     }
        //     else
        //     {
        //         return True;
        //     }


        // }
}

