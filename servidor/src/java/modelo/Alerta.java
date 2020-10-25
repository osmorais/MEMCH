/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modelo;

import java.util.Date;

/**
 *
 * @author osmar
 */
public class Alerta extends Objeto{
    private String descricao;
    private Date data;
    private Regra regra;
    private String descricaoRegra;

    public Alerta() {
    }

    public Alerta(String descricao, Date data, Regra regra, String descricaoRegra) {
        this.descricao = descricao;
        this.data = data;
        this.regra = regra;
        this.descricaoRegra = descricaoRegra;
    }

    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }

    public Date getData() {
        return data;
    }

    public void setData(Date data) {
        this.data = data;
    }

    public Regra getRegra() {
        return regra;
    }

    public void setRegra(Regra regra) {
        this.regra = regra;
    }

    public String getDescricaoRegra() {
        return descricaoRegra;
    }

    public void setDescricaoRegra(String descricaoRegra) {
        this.descricaoRegra = descricaoRegra;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    
}
