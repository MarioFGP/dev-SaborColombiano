using Entity;
using DAL;
using System.Linq;
using System.Collections.Generic;

namespace BLL
{
    public class InsumoService
    {
        private readonly DatosContext _context;


        public InsumoService(){
            _context = new DatosContext();
            _context.Database.EnsureCreated();
            
        }


        public GuardarInsumoResponse GuardarInsumo(Insumo insumo){
            try
            {
                var _insumo = _context.Insumos.Find(insumo.Referencia);
                if(_insumo!=null){
                    return new GuardarInsumoResponse("La referencia ya se encuentra registrada");
                }else{
                    _context.Insumos.Add(insumo);
                    _context.SaveChanges();
                    return new GuardarInsumoResponse(insumo);
                }
            }
            catch (System.Exception e)
            {
                
                return new GuardarInsumoResponse("No se pudo guardar el insumo. "+e.Message);
            }
        }

        public ConsultarInsumoResponse ConsultarInsumo(string referencia){
            try
            {
                var insumo = _context.Insumos.Find(referencia);
                if(insumo!=null){
                    return new ConsultarInsumoResponse(insumo);
                }else{
                    return new ConsultarInsumoResponse("El insumo no existe.");
                }
            }
            catch (System.Exception e)
            {
                
                return new ConsultarInsumoResponse("No se pudo realizar la busqueda. "+e.Message);
            }
        }

        public ConsultarInsumoResponse ConsultarInsumoNombre(string nombre)
        {
            try
            {
                var insumo = _context.Insumos.Where(i => i.Nombre.ToLower().Equals(nombre)).FirstOrDefault();
                if (insumo != null)
                {
                    return new ConsultarInsumoResponse(insumo);
                }
                else
                {
                    return new ConsultarInsumoResponse("El insumo no existe.");
                }
            }
            catch (System.Exception e)
            {

                return new ConsultarInsumoResponse("No se pudo realizar la busqueda. " + e.Message);
            }
        }

        public ConsultarInsumosResponse ConsultarInsumos(){
            try
            {
                var insumos = _context.Insumos.ToList();
                if(insumos!=null){
                    return new ConsultarInsumosResponse(insumos);
                }else{
                    return new ConsultarInsumosResponse("No hay insumos en la base de datos.");
                }
            }
            catch (System.Exception e)
            {
                
                return new ConsultarInsumosResponse("No se pudo hacer la consulta. "+e.Message);
            }
        }

        public GuardarInsumoResponse ModificarInsumo(Insumo insumo){

            try
            {
                var _insumo = _context.Insumos.Find(insumo.Referencia);
                if(_insumo!=null){
                    _insumo.Cantidad = insumo.Cantidad;
                    _insumo.Descripcion = insumo.Descripcion;
                    _insumo.Nombre = insumo.Nombre;
                    _insumo.PrecioUnidad = insumo.PrecioUnidad;
                    _context.Insumos.Update(_insumo);
                    _context.SaveChanges();
                    return new GuardarInsumoResponse(_insumo);
                }else{
                    return new GuardarInsumoResponse("El Insumo no se puede modificar porque no existe.");
                }

            }
            catch (System.Exception e)
            {
                
                return new GuardarInsumoResponse("No se pudo modificar el insumo. "+e.Message);
            }
        }

        


    }


    public class GuardarInsumoResponse{
        public string Mensaje {get; set;}
        public bool Error {get; set;}

        public Insumo Insumo {get; set;}

        public GuardarInsumoResponse(Insumo insumo){
            Insumo = insumo;
            Error = false;
        }

        public GuardarInsumoResponse(string mensaje){
            Mensaje = mensaje;
            Error = true;
        }

        public GuardarInsumoResponse(){

        }

    }


    public class ConsultarInsumosResponse{

        public bool Error {get; set;}
        public string Mensaje {get; set;}
        public List<Insumo> Insumos {get; set;} = new();

        public ConsultarInsumosResponse(List<Insumo> insumos){
            this.Insumos = insumos;
            Error = false;
        }
        public ConsultarInsumosResponse(string mensaje){
            this.Mensaje = mensaje;
            Error = true;
        }

        public ConsultarInsumosResponse(){

        }

    }


    public class ConsultarInsumoResponse{

        public bool Error {get; set;}
        public string Mensaje {get; set;}
        public Insumo Insumo {get; set;}

        public ConsultarInsumoResponse(Insumo insumo){
            this.Insumo = insumo;
            Error = false;
        }
        public ConsultarInsumoResponse(string mensaje){
            this.Mensaje = mensaje;
            Error = true;
        }

        public ConsultarInsumoResponse(){
            
        }

    }


}