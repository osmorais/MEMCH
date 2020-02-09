/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modelo;

import java.util.ArrayList;

/**
 *
 * @author osmar
 */
public class Hidrometro {
    private int id;
    private String chave;
    private String modelo;
    private String descricao;
    private boolean ativo;
    private ArrayList<Registro> registros;
    private ArrayList<Alerta> alertas;
    private ArrayList<Regra> regras;

    public Hidrometro() {
    }

    public Hidrometro(int id, String chave, String modelo, String descricao, boolean ativo, ArrayList<Registro> registros, ArrayList<Alerta> alertas, ArrayList<Regra> regras) {
        this.id = id;
        this.chave = chave;
        this.modelo = modelo;
        this.descricao = descricao;
        this.ativo = ativo;
        this.registros = registros;
        this.alertas = alertas;
        this.regras = regras;
    }

    public String getChave() {
        return chave;
    }

    public void setChave(String chave) {
        this.chave = chave;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getModelo() {
        return modelo;
    }

    public void setModelo(String modelo) {
        this.modelo = modelo;
    }

    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }

    public boolean isAtivo() {
        return ativo;
    }

    public void setAtivo(boolean ativo) {
        this.ativo = ativo;
    }

    public ArrayList<Registro> getRegistros() {
        return registros;
    }

    public void setRegistros(ArrayList<Registro> registros) {
        this.registros = registros;
    }

    public ArrayList<Alerta> getAlertas() {
        return alertas;
    }

    public void setAlertas(ArrayList<Alerta> alertas) {
        this.alertas = alertas;
    }

    public ArrayList<Regra> getRegras() {
        return regras;
    }

    public void setRegras(ArrayList<Regra> regras) {
        this.regras = regras;
    }
    
    
}
