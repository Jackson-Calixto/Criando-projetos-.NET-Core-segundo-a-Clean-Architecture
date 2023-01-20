using CleanArcMvc.Domain.Entities;
using FluentAssertions;
using System;
using Xunit;
using static System.Net.Mime.MediaTypeNames;

namespace CleanArcMvc.Domain.Tests
{
    public class ProductUnitTest1
    {
        [Fact(DisplayName = "Create Product With Valid State")]
        public void CreateProduct_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Product(1, "Product Name", "Description", 0, 0, "", 0);
            action.Should()
                .NotThrow<CleanArcMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateProduct_NegativeIdValue_DomainExceptionInvalidId()
        {
            Action action = () => new Product(-1, "Product Name", "Description", 0, 0, "", 0);
            action.Should()
                .Throw<CleanArcMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Id value");
        }

        [Fact]
        public void CreateProduct_NullName_DomainExceptionInvalidName()
        {
            Action action = () => new Product(1, null, "Description", 0, 0, "", 0);
            action.Should()
                .Throw<CleanArcMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name. Name is required");
        }

        [Fact]
        public void CreateProduct_EmptyName_DomainExceptionInvalidName()
        {
            Action action = () => new Product(1, "", "Description", 0, 0, "", 0);
            action.Should()
                .Throw<CleanArcMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name. Name is required");
        }

        [Fact]
        public void CreateProduct_ShortName_DomainExceptionNameTooShort()
        {
            Action action = () => new Product(1, "Ca", "Description", 0, 0, "", 0);
            action.Should()
                .Throw<CleanArcMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, too short, minimum 3 charecters");
        }

        [Fact]
        public void CreateProduct_NullDescription_DomainExceptionInvalidDescription()
        {
            Action action = () => new Product(1, "Product Name", null, 0, 0, "", 0);
            action.Should()
                .Throw<CleanArcMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid description. Description is required");
        }

        [Fact]
        public void CreateProduct_EmptyDescription_DomainExceptionInvalidDescription()
        {
            Action action = () => new Product(1, "Product Name", "", 0, 0, "", 0);
            action.Should()
                .Throw<CleanArcMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid description. Description is required");
        }

        [Fact]
        public void CreateProduct_ShortDescription_DomainExceptionDescriptionTooShort()
        {
            Action action = () => new Product(1, "Product Name", "Desc", 0, 0, "", 0);
            action.Should()
                .Throw<CleanArcMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid description, too short, minimum 5 charecters");
        }

        [Fact]
        public void CreateProduct_NegativePrice_DomainExceptionInvalidPrice()
        {
            Action action = () => new Product(1, "Product Name", "Description", -1, 0, "", 0);
            action.Should()
                .Throw<CleanArcMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid price value");
        }
        
        [Fact]
        public void CreateProduct_NegativeStock_DomainExceptionInvalidStock()
        {
            Action action = () => new Product(1, "Product Name", "Description", 0, -1, "", 0);
            action.Should()
                .Throw<CleanArcMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid stock value");
        }
        
        [Fact]
        public void CreateProduct_LongImageName_DomainExceptionTooLong()
        {
            Action action = () => new Product(1, "Product Name", "Description", 0, 0, "xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx xxxxxxxxxx ", 0);
            action.Should()
                .Throw<CleanArcMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid image name, too long, maximum 250 charecters");
        }
        
        [Fact]
        public void CreateProduct_WithNullImageName_NoDomainException()
        {
            Action action = () => new Product(1, "Product Name", "Description", 0, 0, null, 0);
            action.Should()
                .NotThrow<CleanArcMvc.Domain.Validation.DomainExceptionValidation>();
        }
        
        [Fact]
        public void CreateProduct_WithNullImageName_NoNullReferenceException()
        {
            Action action = () => new Product(1, "Product Name", "Description", 0, 0, null, 0);
            action.Should()
                .NotThrow<NullReferenceException>();
        }
    }
}
