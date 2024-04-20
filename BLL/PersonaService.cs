using Entity;
using DAL;
using System.Linq;
using System.Collections.Generic;
using System;

namespace BLL
{
    public class PersonaService
    {
        private readonly DatosContext _context;

        

        public PersonaService(){
            _context = new DatosContext();
            _context.Database.EnsureCreated();
        }

        public PersonaResponse GuardarPersona(Persona persona){
            
            try
            {
                var _persona = _context.Personas.Find(persona.Identificacion);
                if(_persona!=null){
                    return new PersonaResponse("No se pudo guardar. La persona ya está registrada.");
                }else{
                    _context.Personas.Add(persona);
                    _context.SaveChanges();
                    return new PersonaResponse(_persona);
                }
            }
            catch (System.Exception e)
            {
                
                return new PersonaResponse("No se pudo guardar. "+e.Message);
            }
        }

        public PersonaResponse ConsultarPersona(string identificacion){

            try
            {
                var persona = _context.Personas.Find(identificacion);
                if(persona!=null){
                    return new PersonaResponse(persona);
                }else{
                    return new PersonaResponse("No se encuentra a la persona.");
                }
            }
            catch (System.Exception e)
            {
                
                return new PersonaResponse("Error en la conexion. "+e.Message);
            }

        }

        public PersonaResponse ConsultarPersonaNombre(string nombre)
        {

            try
            {
                var persona = _context.Personas.Where(p => p.Nombre.ToLower().Equals(nombre.ToLower())).FirstOrDefault();
                if (persona != null)
                {
                    return new PersonaResponse(persona);
                }
                else
                {
                    return new PersonaResponse("No se encuentra a la persona.");
                }
            }
            catch (System.Exception e)
            {

                return new PersonaResponse("Error en la conexion. " + e.Message);
            }

        }

        public ConsultarPersonaResponse ConsultarPersonas(){
            try
            {
                var Personas = _context.Personas.ToList();
                if(Personas!=null){
                    return new ConsultarPersonaResponse(Personas);
                }else{
                    return new ConsultarPersonaResponse("No hay registros de personas.");
                }
            }
            catch (System.Exception e)
            {
                
                return new ConsultarPersonaResponse("No se puedo establecer la conexion. "+e.Message);
            }
        }

        public PersonaResponse ModificarJuridica(Persona persona){
            try
            {
                var _persona = _context.Personas.Find(persona.Identificacion);
                if(_persona!=null){
                    _persona.Correo = persona.Correo;
                    _persona.Descripcion = persona.Descripcion;
                    _persona.Nombre = persona.Nombre;
                    _persona.Telefono = persona.Telefono;
                    _persona.Estado = persona.Estado;
                    _persona.TipoPersona = persona.TipoPersona;
                    _context.Personas.Update(_persona);
                    _context.SaveChanges();
                    return new PersonaResponse(persona);
                }else{
                    return new PersonaResponse("La persona no se encuentra registrada.");
                }
            }
            catch (System.Exception e)
            {
                
                return new PersonaResponse("Error en la conexion"+e.Message);
            }
        }


    }


    
    public class PersonaResponse{
        public bool Error {get; set;}
        public string Mensaje {get; set;}
        public Persona Persona {get; set;}

        public PersonaResponse(Persona persona){
            this.Persona = persona;
            Error = false;

        }

        public PersonaResponse(string mensaje){
            this.Mensaje = mensaje;
            this.Error = true;
        }
    }

    public class ConsultarPersonaResponse{
        public bool Error {get; set;}
        public string Mensaje {get; set;}
        public List<Persona> Personas {get; set;} = new List<Persona>();

        public ConsultarPersonaResponse(List<Persona> personas){
            this.Personas = personas;
            Error = false;
        }

        public ConsultarPersonaResponse(string mensaje){
            this.Mensaje = mensaje;
            Error = true;
        }
    }
}