using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;
using System;

namespace ConsoleApp.Tests
{
	[TestClass]

	public class TestStudentGrades
	{

		private readonly StudentGrades conveter = new StudentGrades();
		private int[] testmarks;

		public TestStudentGrades()
		{
			testmarks = new int[]
			{
				10,20,30,40,50,60,70,80,90,100
			};
		}

		[TestMethod]

		public void TestCovert0ToGradeF()
		{
			// Arange

			Grades expectedGrade = Grades.F;

			//Act

			Grades actualGrade = conveter.ConvertToGrade(0);

			// Assert

			Assert.AreEqual(expectedGrade, actualGrade);

		}


		[TestMethod]
		public void TestCovert39ToGradeF()
		{
			// Arange

			Grades expectedGrade = Grades.F;

			//Act

			Grades actualGrade = conveter.ConvertToGrade(39);

			// Assert

			Assert.AreEqual(expectedGrade, actualGrade);
		}

		[TestMethod]
		public void TestCalculateMean()
		{
			conveter.Marks = testmarks;
			double expectedMean = 55.0;
			conveter.CalculateStats();



			Assert.AreEqual(expectedMean, conveter.Mean);
		}

        [TestMethod]

        public void TestCalculateMin()
		{
			//Arange
			conveter.Marks = testmarks;
			int expectedMin = 0;

			//Act
			conveter.CalculateStats();

			//Assert
			Assert.AreEqual(expectedMin, conveter.Minimum);

		}
        [TestMethod]

        public void TestCalculateMax()
		{
			conveter.Marks = testmarks;
			int expectedMax = 100;

			conveter.CalculateStats();

			Assert.AreEqual(expectedMax, conveter.Maximum);
		}

	        [TestMethod]

			public void TestGradeProfile()
			{

            //Arrange
            conveter.Marks = testmarks;
            bool expectedProfile = false;

            //Act
            conveter.CalculateGradeProfile();
                expectedProfile = ((conveter.GradeProfile[0] == 3) &&
								   (conveter.GradeProfile[1] == 1) &&
								   (conveter.GradeProfile[2] == 1) &&
								   (conveter.GradeProfile[3] == 1) &&
								   (conveter.GradeProfile[4] == 4));
				//Assert
				Assert.IsTrue(expectedProfile);
			}


		}
	}


