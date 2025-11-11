using E_Commerce.Shared.DTOs.ProductDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Services_Abstraction
{
    public interface IProductService
    {
        // Get All Products
        Task<IEnumerable<ProductDTO>> GetAllProductAsync();

        // Get Product By Id
        Task<ProductDTO> GetProductByIdAsync(int id);

        // Get All Brands
        Task<IEnumerable<BrandDTO>> GetAllBrandsAsync();

        // Get All Types
        Task<IEnumerable<TypeDTO>> GetAllTypesAsync();
    }
}
