/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package recurso;

import com.google.gson.Gson;
import com.thoughtworks.xstream.XStream;
import com.thoughtworks.xstream.io.xml.DomDriver;
import java.util.ArrayList;
import javax.ws.rs.core.Context;
import javax.ws.rs.core.UriInfo;
import javax.ws.rs.Consumes;
import javax.ws.rs.Produces;
import javax.ws.rs.GET;
import javax.ws.rs.Path;
import javax.ws.rs.PUT;
import javax.ws.rs.PathParam;
import javax.ws.rs.core.MediaType;
import javax.ws.rs.core.Response;
import modelo.Registro;
import servico.SrvcRegistro;

/**
 * REST Web Service
 *
 * @author osmar
 */
@Path("registro")
public class RecRegistro {
    private final Gson objgson;
    private final XStream xstream;
    
    @Context
    private UriInfo context;
    /**
     * Creates a new instance of RecRegistro
     */
    public RecRegistro() {
        this.objgson = new Gson();
        this.xstream =  new XStream(new DomDriver());
    }
    
    @GET
    @Produces(MediaType.APPLICATION_JSON)
    @Path("listar/json/{id}")
    public Response listarJson(@PathParam("id") Integer id) {
        
        ArrayList<Registro> arrregistro = new ArrayList<>();
        
        arrregistro = SrvcRegistro.listar(id);
        String retorno = objgson.toJson(arrregistro);
        
        return Response.status(200).entity(retorno).header("Access-Control-Allow-Origin", "*").build();
    }

    /**
     * PUT method for updating or creating an instance of RecRegistro
     * @param content representation for the resource
     */
    @PUT
    @Consumes(MediaType.APPLICATION_JSON)
    public void putJson(String content) {
    }
}
