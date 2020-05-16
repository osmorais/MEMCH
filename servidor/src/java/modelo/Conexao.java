/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modelo;

/**
 *
 * @author osmar
 */
public class Conexao extends Objeto{
    private String host;
    private boolean ativo;
    private String descricao;
    private Hidrometro hidrometro;

    public Conexao() {
    }

    public Conexao(String host, boolean ativo, String descricao, Hidrometro hidrometro) {
        this.host = host;
        this.ativo = ativo;
        this.descricao = descricao;
        this.hidrometro = hidrometro;
    }

    @Override
    public int getId() {
        return id;
    }

    @Override
    public void setId(int id) {
        this.id = id;
    }
    
    public String getHost() {
        return host;
    }

    public void setHost(String host) {
        this.host = host;
    }

    public boolean isAtivo() {
        return ativo;
    }

    public void setAtivo(boolean ativo) {
        this.ativo = ativo;
    }

    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }

    public Hidrometro getHidrometro() {
        return hidrometro;
    }

    public void setHidrometro(Hidrometro hidrometro) {
        this.hidrometro = hidrometro;
    }
}
