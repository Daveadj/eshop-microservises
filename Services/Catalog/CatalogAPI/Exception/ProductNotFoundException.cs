﻿using BuildingBlocks.Exception;

namespace CatalogAPI.Exceptions
{
    public class ProductNotFoundException : NotFoundException
    {
        public ProductNotFoundException(Guid id) : base("Product not found!", id)
        {
        }
    }
}