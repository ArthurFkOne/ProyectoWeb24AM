using Microsoft.EntityFrameworkCore;
using ProyectoWeb24AM.Context;
using ProyectoWeb24AM.Models.Entities;
using ProyectoWeb24AM.Services.IServices;

namespace ProyectoWeb24AM.Services.Service
{
    public class ArticuloServices: IArticuloServices
    {
        private readonly ApplicationDBContext _context;
        public ArticuloServices(ApplicationDBContext context)
        {
            _context=context;
        }

        public async Task<List<Articulo>> GetArticulos()
        {
            try
            {
               
                return await _context.Articulos.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Surgio un error"+ex.Message);
            }

        }

        public async Task<Articulo> GetArticulo(int id)
        {
            try
            {

                Articulo articulos = await _context.Articulos.FindAsync(id);
                return articulos;

            }
            catch (Exception ex)
            {
                throw new Exception("Surgio un error" + ex.Message);
            }

        }


        public async Task<Articulo> DeleteArticulo(int id)
        {
            try
            {

                Articulo articulos = await _context.Articulos.FindAsync(id);
                _context.Remove(articulos);
                await _context.SaveChangesAsync();
                return articulos;

            }
            catch (Exception ex)
            {
                throw new Exception("Surgio un error" + ex.Message);
            }

        }

        public async Task<Articulo> UpdateArticulo(Articulo i)
        {
            try
            {

                Articulo articulos = await _context.Articulos.FindAsync(i.PkArticulo);
                articulos.Nombre= i.Nombre;
                articulos.Descripcion = i.Descripcion;
                articulos.Precio=i.Precio;
                var result= _context.Update(articulos);
                await _context.SaveChangesAsync();
                return articulos;
            }
            catch (Exception ex)
            {
                throw new Exception("Surgio un error" + ex.Message);
            }

        }


        public async Task<Articulo> CreateArticulo(Articulo i)
        {
            try
            {

                Articulo request = new Articulo()
                {

                    Nombre = i.Nombre,
                    Descripcion = i.Descripcion,
                    Precio=i.Precio,


                };

                var result =  _context.Articulos.Add(request);
                await _context.SaveChangesAsync();

                return request;


            }
            catch (Exception ex)
            {
                throw new Exception("Surgio un error" + ex.Message);
            }

        }

    }
}
