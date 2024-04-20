using Entity;
using DAL;
using System.Linq;
using System.Collections.Generic;

namespace BLL
{

    public class UsuarioService
    {
        private readonly DatosContext _context;

        public UsuarioService(){
            _context = new DatosContext();
            _context.Database.EnsureCreated();
        }


        public GuardarUsuarioResponse GuardarUsuario(Usuario usuario){

            try
            {
                var user = _context.Usuario.Find(usuario.IdUsuario);
                if(user!=null){
                    return new GuardarUsuarioResponse("Ya existe el usuario");
                }else{
                    _context.Usuario.Add(usuario);
                    _context.SaveChanges();
                    return new GuardarUsuarioResponse(usuario);
                }
            }
            catch (System.Exception e)
            {
                
                return new GuardarUsuarioResponse("No se puedo guardar el usuario"+e.Message);
            }
            
        }

        public ConsultarUsuarioResponse ConsultarUsuario(string identificacion){
        
            try
            {
                var usuario = _context.Usuario.Find(identificacion);
                if(usuario!=null){
                    return new ConsultarUsuarioResponse(usuario);

                }else{
                    return new ConsultarUsuarioResponse("El usuario no existe");
                }
            }
            catch (System.Exception e)
            {
                
                return new ConsultarUsuarioResponse("No se pudo concretar la busqueda. "+e.Message);
            }
        }

        public GuardarUsuarioResponse ModificarUsuario(Usuario usuario){
            try
            {
                var _usuario = _context.Usuario.Find(usuario.IdUsuario);
                if(_usuario!=null){
                    _usuario.Contraseña = usuario.Contraseña;
                    _usuario.Estado = usuario.Estado;
                    _usuario.Nombre = usuario.Nombre;
                    _context.Usuario.Update(usuario);
                    _context.SaveChanges();
                    return new GuardarUsuarioResponse(_usuario);
                }else{
                    return new GuardarUsuarioResponse("No existe el usuario.");
                }
            }
            catch (System.Exception e)
            {
                
                return new GuardarUsuarioResponse("No se pudo modificar el usuario. "+e.Message);
            }
        }

public ConsultarUsuariosResponse ConsultarUsuarios(){
        
            try
            {
                var usuarios = _context.Usuario.ToList();
                if(usuarios!=null){
                    return new ConsultarUsuariosResponse(usuarios);

                }else{
                    return new ConsultarUsuariosResponse("No hay registro de usuarios");
                }
            }
            catch (System.Exception e)
            {
                
                return new ConsultarUsuariosResponse("No se pudo concretar la busqueda. "+e.Message);
            }
        }




    }



    public class GuardarUsuarioResponse{

        public bool Error {get; set;}
        public string Mensaje {get; set;}
        public Usuario Usuario {get; set;}
        public GuardarUsuarioResponse(Usuario usuario){
            Error = false;
            this.Usuario = usuario;
        }

        public GuardarUsuarioResponse(){

        }
        public GuardarUsuarioResponse(string mensaje){
            this.Mensaje = mensaje;
            Error = true;
        }
    }

    public class ConsultarUsuariosResponse{
        public bool Error {get; set;}
        public string Mensaje {get; set;}
        public List<Usuario> Usuarios = new();
        
        public ConsultarUsuariosResponse(){

        }

        public ConsultarUsuariosResponse(List<Usuario> usuarios){
            Error = false;
            this.Usuarios = usuarios;
        }

        public ConsultarUsuariosResponse(string mensaje){
            this.Mensaje = mensaje;
        }

    }

    public class ConsultarUsuarioResponse{
        public bool Error {get; set;}
        public string Mensaje {get; set;}

        public Usuario Usuario {get; set;}

        public ConsultarUsuarioResponse(Usuario usuario){
            this.Usuario = usuario;
            Error = false;

        }

        public ConsultarUsuarioResponse(string mensaje){
            Mensaje = mensaje;
            Error = true; 
        }
    }

}