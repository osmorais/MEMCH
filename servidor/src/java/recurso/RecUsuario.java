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
import javax.ws.rs.core.MediaType;
import modelo.Usuario;
import servico.SrvcHidrometro;

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
    
    @POST
    @Consumes(MediaType.APPLICATION_JSON)
    @Produces(MediaType.APPLICATION_JSON)
    @Path("consultar/json")
    public String consultarJson(String conteudo) {
        
        Usuario hidrometro = objgson.fromJson(conteudo, Usuario.class);
        SrvcHidrometro.consultar(hidrometro);
        
        String retorno = objgson.toJson(hidrometro);

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
