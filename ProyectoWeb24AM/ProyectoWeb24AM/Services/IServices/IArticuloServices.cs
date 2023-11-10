using ProyectoWeb24AM.Models.Entities;

namespace ProyectoWeb24AM.Services.IServices
{
    public interface IArticuloServices
    {
        public Task<List<Articulo>> GetArticulos();
        public Task<Articulo> GetArticulo(int id);
        public Task<Articulo> DeleteArticulo(int id);
        public Task<Articulo> UpdateArticulo(Articulo id);
        public Task<Articulo> CreateArticulo(Articulo i);
    }
}
