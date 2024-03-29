using CleanArcMvc.Domain.Entities;
using FluentAssertions;
using System;
using Xunit;

namespace CleanArcMvc.Domain.Tests;

public class CategoryUnitTest1
{
    [Fact(DisplayName = "Create Category With Valid State")]
    public void CreateCategory_WithValidParameters_ResultObjectValidState()
    {
        Action action = () => new Category(1, "Category Name");
        action.Should()
            .NotThrow<CleanArcMvc.Domain.Validation.DomainExceptionValidation>();
    }

    [Fact]
    public void CreateCategory_NegativeIdValue_DomainExceptionInvalidId()
    {
        Action action = () => new Category(-1, "Category Name");
        action.Should()
            .Throw<CleanArcMvc.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("Invalid Id value");
    }

    [Fact]
    public void CreateCategory_NameNull_DomainExceptionInvalidName()
    {
        Action action = () => new Category(1, null);
        action.Should()
            .Throw<CleanArcMvc.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("Invalid name. Name is required");
    }

    [Fact]
    public void CreateCategory_NameEmpty_DomainExceptionInvalidName()
    {
        Action action = () => new Category(1, "");
        action.Should()
            .Throw<CleanArcMvc.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("Invalid name. Name is required");
    }

    [Fact]
    public void CreateCategory_ShortName_DomainExceptionNameTooShort()
    {
        Action action = () => new Category(1, "Ca");
        action.Should()
            .Throw<CleanArcMvc.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("Invalid name, too short, minimum 3 charecters");
    }
}
