
using Microsoft.EntityFrameworkCore;
using PhilBodPill.Models;
using PhilBodPill.Data;
using System;
using Xunit;

namespace PhilBodPillTests
{
    public class UnitTest1
    {
        // PRODUCT TESTS
        [Fact]
        public void CanGetName()
        {
            Product testProduct = new Product();
            testProduct.Name = "test";
            Assert.Equal("test", testProduct.Name);
        }

        [Fact]
        public void CanSetName()
        {
            Product testProduct = new Product();
            testProduct.Name = "test";
            testProduct.Name = "different";
            Assert.Equal("different", testProduct.Name);
        }

        [Fact]
        public void CanGetImage()
        {
            Product testProduct = new Product();
            testProduct.Image = "./img/test";
            Assert.Equal("./img/test", testProduct.Image);
        }

        [Fact]
        public void CanSetImage()
        {
            Product testProduct = new Product();
            testProduct.Image = "./img/test";
            testProduct.Image = "./img/test2";
            Assert.Equal("./img/test2", testProduct.Image);
        }

        [Fact]
        public void CanGetPrice()
        {
            Product testProduct = new Product();
            testProduct.Price = 14.99M;
            Assert.Equal(14.99M, testProduct.Price);
        }

        [Fact]
        public void CanSetPrice()
        {
            Product testProduct = new Product();
            testProduct.Price = 14.99M;
            testProduct.Price = 15.99M;
            Assert.Equal(15.99M, testProduct.Price);
        }

        [Fact]
        public void CanGetDescription()
        {
            Product testProduct = new Product();
            testProduct.Description = "Testing";
            Assert.Equal("Testing", testProduct.Description);
        }

        [Fact]
        public void CanSetDescription()
        {
            Product testProduct = new Product();
            testProduct.Description = "Testing";
            testProduct.Description = "Testing even harder";
            Assert.Equal("Testing even harder", testProduct.Description);
        }
    }
}
