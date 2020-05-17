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
import modelo.Conexao;
import servico.SrvcConexao;

/**
 * REST Web Service
 *
 * @author osmar
 */
@Path("conexao")
public class RecConexao {
    private final Gson objgson;
    private final XStream xstream;

    @Context
    private UriInfo context;

    /**
     * Creates a new instance of RecConexao
     */
    public RecConexao() {
        this.objgson = new Gson();
        this.xstream =  new XStream(new DomDriver());
    }

    /**
     * Retrieves representation of an instance of recurso.RecConexao
     * @return an instance of java.lang.String
     */
    @GET
    @Produces(MediaType.APPLICATION_XML)
    public String getXml() {
        //TODO return proper representation object
        throw new UnsupportedOperationException();
    }
    
    @GET
    @Produces(MediaType.APPLICATION_JSON)
    @Path("listar/json")
    public String listarJson() {
        
        ArrayList<Conexao> arrconexao = new ArrayList<>();
        
        arrconexao = SrvcConexao.listar();
        String retorno = objgson.toJson(arrconexao);
        
        return retorno;
    }
    
    @POST
    @Consumes(MediaType.APPLICATION_JSON)
    @Produces(MediaType.APPLICATION_JSON)
    @Path("cadastrar/json")
    public String cadastrarJson(String conteudo) {
        
        Conexao conexao = objgson.fromJson(conteudo, Conexao.class);
        SrvcConexao.cadastrar(conexao);
        
        String retorno = objgson.toJson(conexao);

        return retorno;
    }
    
    @POST
    @Consumes(MediaType.APPLICATION_JSON)
    @Produces(MediaType.APPLICATION_JSON)
    @Path("alterar/json")
    public String alterarJson(String conteudo) {
        
        Conexao conexao = objgson.fromJson(conteudo, Conexao.class);
        SrvcConexao.alterar(conexao);
        
        String retorno = objgson.toJson(conexao);

        return retorno;
    }
    
    @POST
    @Consumes(MediaType.APPLICATION_JSON)
    @Produces(MediaType.APPLICATION_JSON)
    @Path("remover/json")
    public String removerJson(String conteudo) {
        
        Conexao conexao = objgson.fromJson(conteudo, Conexao.class);
        SrvcConexao.remover(conexao);
        
        String retorno = objgson.toJson(conexao);

        return retorno;
    }

    /**
     * PUT method for updating or creating an instance of RecConexao
     * @param content representation for the resource
     */
    @PUT
    @Consumes(MediaType.APPLICATION_XML)
    public void putXml(String content) {
    }
}
