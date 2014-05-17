package j2e.domain;

import javax.jws.WebService;

import j2e.entities.Utilisateur;

@WebService
public interface UtilisateurFinder {

	public Utilisateur findUtilisateurByLogin(String login);
}
