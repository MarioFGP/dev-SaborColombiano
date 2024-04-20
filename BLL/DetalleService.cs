using Entity;
using DAL;
using System.Linq;
using System.Collections.Generic;

namespace BLL
{
    public class DetalleService
    {
        private readonly DatosContext _context;

        public DetalleService(){
            _context = new DatosContext();
            _context.Database.EnsureCreated();
        }

        public GuardarDetalleResponde GuardarDetalle(Detalle detalle){
            try
            {
                var _detalle = _context.Detalles.Find(detalle.Codigo);

                if(_detalle!=null){
                    return new GuardarDetalleResponde("Ya existe el detalle.");
                }else{
                    _context.Detalles.Add(detalle);
                    _context.SaveChanges();
                    return new GuardarDetalleResponde(detalle);
                }

            }
            catch (System.Exception e)
            {
                
                return new GuardarDetalleResponde("Hubo un problema al intentar guardar el detalle. "+e.Message);
            }
        }


        public ConsultarDetallesResponse ConsultarDetalles(){
            try
            {
                var detalles = _context.Detalles.ToList();

                if(detalles!=null){
                    return new ConsultarDetallesResponse(detalles);
                }else{
                    return new ConsultarDetallesResponse("No hay registros de detalle.");
                }
            }
            catch (System.Exception e)
            {
                
                return new ConsultarDetallesResponse("Problemas al intentar consultar. "+e.Message);
            }
        }


    }


    public class GuardarDetalleResponde{
        public bool Error {get; set;}
        public string Mensaje {get; set;}
        public Detalle Detalle {get; set;}

        public GuardarDetalleResponde(Detalle detalle){
            Detalle = detalle;
            Error = false;
        }

        public GuardarDetalleResponde(string mensaje){
            Mensaje = mensaje;
            Error = true;
        }

        public GuardarDetalleResponde(){

        }
    }


    public class ConsultarDetallesResponse{
        public bool Error {get; set;}
        public string Mensaje {get; set;}

        public List<Detalle> Detalles {get; set;} = new();

        public ConsultarDetallesResponse(List<Detalle> detalles){
            Detalles = detalles;
            Error = false;
        }

        public ConsultarDetallesResponse(string mensaje){
            Mensaje = mensaje;
            Error = true;
        }

        public ConsultarDetallesResponse(){

        }

    }
}