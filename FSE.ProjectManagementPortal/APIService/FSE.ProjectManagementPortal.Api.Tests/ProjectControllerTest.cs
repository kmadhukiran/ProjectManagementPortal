﻿using FSE.ProjectManagementPortal.Api.Controllers;
using FSE.ProjectManagementPortal.DataContract;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FSE.ProjectManagementPortal.Api.Tests
{
    [TestClass]
    public class ProjectControllerTest
    {
        ProjectController projectController;

        /// <summary>
        /// Get the active Project details
        /// </summary>
        [TestMethod]
        public void GetActiveProjectDetails_ShouldNotNull()
        {
            //Arrange
            projectController = new ProjectController();

            //Act
            var projectList = projectController.GetAllProjectDetails();

            //Assert
            Assert.IsNotNull(projectList);
            Assert.IsTrue(projectList.Count > 0);
        }

        /// <summary>
        /// Insert project details and get success
        /// </summary>
        [TestMethod]
        public void InsertProjectDetails_Successfully()
        {
            //Arrange
            projectController = new ProjectController();
            ProjectModel projectModel = new ProjectModel
            {

                Project = "This is the Unit test Project Name",
                Start_Date = DateTime.Parse("15-11-2018"),
                End_Date = DateTime.Parse("25-11-2018"),
                Priority = 2,
                Status = true,
                Manager_ID = "103"
            };
            //Act
            int returnVal = projectController.InserProjectModel(projectModel);

            //Assert            
            Assert.IsNotNull(returnVal);
            Assert.AreEqual(1, returnVal);
        }

        /// <summary>
        /// Update project details and get success
        /// </summary>
        [TestMethod]
        public void UpdateProjectDetails_Successfully()
        {
            //Arrange
            projectController = new ProjectController();
            ProjectModel projectModel = new ProjectModel
            {
                Project_ID = 2003,
                Project = " Updated Project Name Test",
                Start_Date = DateTime.Parse("15-11-2019"),
                End_Date = DateTime.Parse("25-11-2019"),
                Priority = 2,
                Status = true,
                Manager_ID = "1"
            };
            //Act
            int returnVal = projectController.UpdaterojectModel(projectModel);

            //Assert            
            Assert.IsNotNull(returnVal);
            Assert.AreEqual(1, returnVal);
        }
    }
}
