using ForestAPI.Controllers;
using ForestAPI.Data;
using Microsoft.EntityFrameworkCore;
using ForestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ForestAPI.DTO_s;

namespace ForestAPITests
{
    public class PageTests
    {
        private readonly ForestDbContext _context;
        private readonly PageController controller;
        private List<Page> _pages = new List<Page>();
        private List<Category> _categories = new List<Category>();

        public PageTests()
        {
            var options = new DbContextOptionsBuilder<ForestDbContext>()
                .UseInMemoryDatabase(databaseName: "db").Options;

            _context = new ForestDbContext(options);
            _context.Database.EnsureDeleted();
            _context.Categories.AddRange(seeb());
            _context.Pages.AddRange(seed());
            _context.SaveChanges();

            controller = new PageController(_context);
        }
        //setting up a list of pages to put into the fake database to test with it
        private List<Page> seed()
        {
            List<Page> pages = new List<Page>
            {
                new Page
                {
                    PageID = 1,
                    Title = "stok",
                    Information = "you can hit someone with it",
                    CategoryID = 1,
                    LastUpdated = DateTime.Now

                },
                new Page
                {
                    PageID = 2,
                    Title = "stone",
                    Information = "you can throw it",
                    CategoryID = 1,
                    LastUpdated = DateTime.Now

                },
                new Page
                {
                    PageID = 3,
                    Title = "cannibal",
                    Information = "he tries to eat you when you're asleep",
                    CategoryID = 2,
                    LastUpdated = DateTime.Now

                },


            };
            _pages = pages;
            return pages;
        }
        //making a list of categories to put in the database. Pages have a foreign key with it so it would be fun to test with it
        private List<Category> seeb()
        {
            List<Category> categories = new List<Category>
            {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "items"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "enemies"
                }
            };
            _categories = categories;
            return categories;
        }

        [Fact]
        public async void GetAllPagesTest()
        {
            //arrange

            //act
            var response = await controller.Get();
            List<Page>? pages = (List<Page>?)response;

            //assert
            Assert.NotNull(pages);
            Assert.Equal(_pages, pages);

        }

        [Fact]
        public async void GetByIDTest_Good()
        {
            //arrange

            //act
            var response = await controller.GetById(1);
            var result = (ObjectResult)response;
            Page? page = (Page?)result.Value;

            //assert
            Assert.NotNull(result);
            Assert.NotNull(page);
            Assert.Equal(200, result.StatusCode);
            Assert.Equal(_pages[0], page);
        }


        [Fact]
        public async void GetByIDTest_Bad()
        {
            //arrange

            //act
            var response = await controller.GetById(69);
            var result = (NotFoundResult)response;

            //assert
            Assert.NotNull(result);
            Assert.Equal(404, result.StatusCode);
        }


        [Fact]
        public async void CreatePage_Good()
        {
            //arrange
            PageDTO newPage = new PageDTO
            {
                PageID = 5,
                Title = "leaf",
                Information = "falls of a tree",
                CategoryID = 1
            };
            //act
            var response = await controller.CreatePage(newPage);
            var result = (ObjectResult)response;

            //assert
            Assert.NotNull(result);
            Assert.Equal(201, result.StatusCode);

        }
        
        


    }


}
