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
import javax.ws.rs.core.MediaType;
import modelo.RegraTipo;
import servico.SrvcRegraTipo;

/**
 * REST Web Service
 *
 * @author osmar
 */
@Path("regratipo")
public class RecRegraTipo {
    private final Gson objgson;
    private final XStream xstream;

    @Context
    private UriInfo context;

    /**
     * Creates a new instance of RecRegraTipo
     */
    public RecRegraTipo() {
        this.objgson = new Gson();
        this.xstream =  new XStream(new DomDriver());
    }

    /**
     * Retrieves representation of an instance of recurso.RecRegraTipo
     * @return an instance of java.lang.String
     */
    @GET
    @Produces(MediaType.APPLICATION_JSON)
    @Path("listar/json")
    public String listarJson() {
        
        ArrayList<RegraTipo> arrregratipo = new ArrayList<>();
        
        arrregratipo = SrvcRegraTipo.listar();
        String retorno = objgson.toJson(arrregratipo);
        
        return retorno;
    }

    /**
     * PUT method for updating or creating an instance of RecRegraTipo
     * @param content representation for the resource
     */
    @PUT
    @Consumes(MediaType.APPLICATION_XML)
    public void putXml(String content) {
    }
}
