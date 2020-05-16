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
public class Regra {
    private int id;
    private double valor;
    private int periodo;
    private RegraTipo tipo;
    private boolean ativo;

    public Regra() {
    }

    public Regra(int id, double valor, int periodo, RegraTipo tipo, boolean ativo) {
        this.id = id;
        this.valor = valor;
        this.periodo = periodo;
        this.tipo = tipo;
        this.ativo = ativo;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public double getValor() {
        return valor;
    }

    public void setValor(double valor) {
        this.valor = valor;
    }

    public int getPeriodo() {
        return periodo;
    }

    public void setPeriodo(int periodo) {
        this.periodo = periodo;
    }

    public RegraTipo getTipo() {
        return tipo;
    }

    public void setTipo(RegraTipo tipo) {
        this.tipo = tipo;
    }

    public boolean isAtivo() {
        return this.ativo;
    }

    public void setAtivo(boolean ativo) {
        this.ativo = ativo;
    }
}
