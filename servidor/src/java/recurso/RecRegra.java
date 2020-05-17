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
import javax.ws.rs.POST;
import javax.ws.rs.Path;
import javax.ws.rs.PUT;
import javax.ws.rs.core.MediaType;
import modelo.Regra;
import servico.SrvcRegra;

/**
 * REST Web Service
 *
 * @author osmar
 */
@Path("regra")
public class RecRegra {
    private final Gson objgson;
    private final XStream xstream;
    
    @Context
    private UriInfo context;

    /**
     * Creates a new instance of RecRegra
     */
    public RecRegra() {
        this.objgson = new Gson();
        this.xstream =  new XStream(new DomDriver());
    }

    /**
     * Retrieves representation of an instance of recurso.RecRegra
     * @return an instance of java.lang.String
     */
//    @GET
//    @Produces(MediaType.APPLICATION_JSON)
//    @Path("listar/json")
//    public String listarJson() {
//        
//        ArrayList<Regra> arrregra = new ArrayList<>();
//        
//        arrregra = SrvcRegra.listar();
//        String retorno = objgson.toJson(arrregra);
//        
//        return retorno;
//    }
    
    @POST
    @Consumes(MediaType.APPLICATION_JSON)
    @Produces(MediaType.APPLICATION_JSON)
    @Path("remover/json")
    public String removerJson(String conteudo) {
        
        Regra regra = objgson.fromJson(conteudo, Regra.class);
        SrvcRegra.remover(regra);
        
        String retorno = objgson.toJson(regra);

        return retorno;
    }
    

    /**
     * PUT method for updating or creating an instance of RecRegra
     * @param content representation for the resource
     */
    @PUT
    @Consumes(MediaType.APPLICATION_XML)
    public void putXml(String content) {
    }
}
