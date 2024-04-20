using Entity;
using DAL;
using System.Linq;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class PlatilloService
    {
        private readonly DatosContext _context;

        public PlatilloService()
        {
            _context = new DatosContext();
            _context.Database.EnsureCreated();
        }

        public PlatilloResponse GuardarPlatillo(Platillo platillo)
        {
            try
            {
                var _platillo = _context.Platillos.Find(platillo.Referencia);
                if (_platillo != null)
                {
                    return new PlatilloResponse("El platillo ya existe.");
                }
                else
                {
                    _context.Platillos.Add(platillo);
                    _context.SaveChanges();
                    return new PlatilloResponse(platillo);
                }
            }
            catch (System.Exception e)
            {

                return new PlatilloResponse("Error de conexion. " + e.Message);
            }
        }

        public PlatilloResponse ConsultarPlatillo(string referencia)
        {
            try
            {
                var platilo = _context.Platillos.Find(referencia);
                if (platilo != null)
                {
                    return new PlatilloResponse(platilo);
                }
                else
                {
                    return new PlatilloResponse("No existe el platillo.");
                }
            }
            catch (System.Exception e)
            {

                return new PlatilloResponse("Error de conexion. " + e.Message);
            }
        }

        public PlatilloResponse ConsultarPlatilloNombre(string Nombre)
        {
            try
            {
                var platillo = _context.Platillos.Where(p => p.Descripcion.Equals(Nombre)).FirstOrDefault();
                if (platillo != null)
                {
                    return new PlatilloResponse(platillo);
                }
                else
                {
                    return new PlatilloResponse("No existe el platillo.");
                }
            }
            catch (System.Exception e)
            {

                return new PlatilloResponse("Error de conexion. " + e.Message);
            }
        }

        public ConsultarPlatillosResponse ConsultarPlatillos()
        {
            try
            {
                var platillos = _context.Platillos.ToList();
                if (platillos != null)
                {
                    return new ConsultarPlatillosResponse(platillos);
                }
                else
                {
                    return new ConsultarPlatillosResponse("No hay platillos.");
                }
            }
            catch (System.Exception e)
            {

                return new ConsultarPlatillosResponse("Error de conexion. " + e.Message);
            }
        }

        public PlatilloResponse ModificarPlatillo(Platillo platillo)
        {
            try
            {
                var _platillo = _context.Platillos.Find(platillo.Referencia);
                if (_platillo != null)
                {
                    _platillo.Descripcion = platillo.Descripcion;
                    _platillo.Disponibilidad = platillo.Disponibilidad;
                    _platillo.Precio = platillo.Precio;
                    _context.Platillos.Update(_platillo);
                    _context.SaveChanges();
                    return new PlatilloResponse(platillo);
                }
                else
                {
                    return new PlatilloResponse("No existe el platillo");
                }
            }
            catch (System.Exception e)
            {

                return new PlatilloResponse("Error de conexion. " + e.Message);
            }
        }

        
    }

    public class PlatilloResponse
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Platillo Platillo { get; set; }

        public PlatilloResponse(Platillo platillo)
        {
            this.Platillo = platillo;
            Error = false;

        }

        public PlatilloResponse(string mensaje)
        {
            this.Mensaje = mensaje;
            this.Error = true;
        }
    }

    public class ConsultarPlatillosResponse{

        public bool Error {get; set;}
        public string Mensaje {get; set;}
        public List<Platillo> Platillos {get; set;} = new();

        public ConsultarPlatillosResponse(List<Platillo> Platillos){
            this.Platillos = Platillos;
            Error = false;
        }
        public ConsultarPlatillosResponse(string mensaje){
            this.Mensaje = mensaje;
            Error = true;
        }

        public ConsultarPlatillosResponse(){

        }

    }

}