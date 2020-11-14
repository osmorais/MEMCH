/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package recurso;

import com.google.gson.Gson;
import com.thoughtworks.xstream.XStream;
import com.thoughtworks.xstream.io.xml.DomDriver;
import javax.ws.rs.core.Context;
import javax.ws.rs.core.UriInfo;
import javax.ws.rs.Consumes;
import javax.ws.rs.Produces;
import javax.ws.rs.GET;
import javax.ws.rs.POST;
import javax.ws.rs.Path;
import javax.ws.rs.PUT;
import javax.ws.rs.PathParam;
import javax.ws.rs.core.MediaType;
import javax.ws.rs.core.Response;
import modelo.Usuario;
import servico.SrvcUsuario;

/**
 * REST Web Service
 *
 * @author osmar
 */
@Path("usuario")
public class RecUsuario {
    private final Gson objgson;
    private final XStream xstream;

    @Context
    private UriInfo context;

    /**
     * Creates a new instance of RecUsuario
     */
    public RecUsuario() {
        this.objgson = new Gson();
        this.xstream =  new XStream(new DomDriver());
    }
    
    @GET
    @Produces(MediaType.APPLICATION_JSON)
    @Path("consultar/{id}")
    public Response consultar(@PathParam("id") Integer id) {
        
        Usuario usuario = new Usuario();
        usuario.setId(id);
        
        SrvcUsuario.consultar(usuario);
        
        String retorno = objgson.toJson(usuario);

        return Response.status(200).entity(retorno).header("Access-Control-Allow-Origin", "*").build();
    }
    
    @POST
    @Consumes(MediaType.APPLICATION_JSON)
    @Produces(MediaType.APPLICATION_JSON)
    @Path("consultarLogin")
    public Response consultarLogin(String conteudo) {
        
        Usuario usuario = objgson.fromJson(conteudo, Usuario.class);
        SrvcUsuario.consultarLogin(usuario);
        
        String retorno = objgson.toJson(usuario);

        return Response.status(200).entity(retorno).header("Access-Control-Allow-Origin", "*").build();
    }
    
    @POST
    @Consumes(MediaType.APPLICATION_JSON)
    @Produces(MediaType.APPLICATION_JSON)
    @Path("consultarLogin/json")
    public String consultarJson(String conteudo) {
        
        Usuario usuario = objgson.fromJson(conteudo, Usuario.class);
        SrvcUsuario.consultarLogin(usuario);
        
        String retorno = objgson.toJson(usuario);

        return retorno;
    }
    
    @POST
    @Consumes(MediaType.APPLICATION_JSON)
    @Produces(MediaType.APPLICATION_JSON)
    @Path("cadastrar")
    public Response cadastrar(String conteudo) {
        
        Usuario usuario = objgson.fromJson(conteudo, Usuario.class);
        
        usuario = SrvcUsuario.cadastrar(usuario);
        
        String retorno = objgson.toJson(usuario);

        return Response.status(200).entity(retorno).header("Access-Control-Allow-Origin", "*").build();
    }
    
    @POST
    @Consumes(MediaType.APPLICATION_JSON)
    @Produces(MediaType.APPLICATION_JSON)
    @Path("cadastrar/json")
    public String cadastrarJson(String conteudo) {
        
        Usuario usuario = objgson.fromJson(conteudo, Usuario.class);
        
        usuario = SrvcUsuario.cadastrar(usuario);
        
        String retorno = objgson.toJson(usuario);

        return retorno;
    }
    
    @PUT
    @Consumes(MediaType.APPLICATION_JSON)
    @Produces(MediaType.APPLICATION_JSON)
    @Path("alterar")
    public Response alterar(String conteudo) {
        
        Usuario usuario = objgson.fromJson(conteudo, Usuario.class);
        
        usuario = SrvcUsuario.alterar(usuario);
        
        String retorno = objgson.toJson(usuario);

        return Response.status(200).entity(retorno).header("Access-Control-Allow-Origin", "*").build();
    }
    
    @POST
    @Consumes(MediaType.APPLICATION_JSON)
    @Produces(MediaType.APPLICATION_JSON)
    @Path("alterar/json")
    public String alterarJson(String conteudo) {
        
        Usuario usuario = objgson.fromJson(conteudo, Usuario.class);
        usuario = SrvcUsuario.alterar(usuario);
        
        String retorno = objgson.toJson(usuario);

        return retorno;
    }
    
    @POST
    @Consumes(MediaType.APPLICATION_JSON)
    @Produces(MediaType.APPLICATION_JSON)
    @Path("remover/json")
    public String removerJson(String conteudo) {
        
        Usuario usuario = objgson.fromJson(conteudo, Usuario.class);
        SrvcUsuario.remover(usuario);
        
        String retorno = objgson.toJson(usuario);

        return retorno;
    }

    /**
     * Retrieves representation of an instance of recurso.RecUsuario
     * @return an instance of java.lang.String
     */
    @GET
    @Produces(MediaType.APPLICATION_XML)
    public String getXml() {
        //TODO return proper representation object
        throw new UnsupportedOperationException();
    }

    /**
     * PUT method for updating or creating an instance of RecUsuario
     * @param content representation for the resource
     */
    @PUT
    @Consumes(MediaType.APPLICATION_XML)
    public void putXml(String content) {
    }
}
