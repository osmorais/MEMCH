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
public class Usuario extends Objeto{
    private String login;
    private String senha;
    private ArrayList<Conexao> conexoes;
    private Pessoa pessoa;
    private String email;

    public Usuario() {
    }

    public Usuario(String login, String senha, ArrayList<Conexao> conexoes, Pessoa pessoa, String email) {
        this.login = login;
        this.senha = senha;
        this.conexoes = conexoes;
        this.pessoa = pessoa;
        this.email = email;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getLogin() {
        return login;
    }

    public void setLogin(String login) {
        this.login = login;
    }

    public String getSenha() {
        return senha;
    }

    public void setSenha(String senha) {
        this.senha = senha;
    }

    public ArrayList<Conexao> getConexoes() {
        return conexoes;
    }

    public void setConexoes(ArrayList<Conexao> conexoes) {
        this.conexoes = conexoes;
    }

    public Pessoa getPessoa() {
        return pessoa;
    }

    public void setPessoa(Pessoa pessoa) {
        this.pessoa = pessoa;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }
}
