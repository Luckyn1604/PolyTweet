package j2e.domain.impl;

import j2e.domain.UtilisateurFinder;
import j2e.entities.Utilisateur;

import javax.ejb.Stateless;
import javax.jws.WebService;

@Stateless
@WebService
public class UtilisateurFinderBean extends FinderBean implements UtilisateurFinder {

	public Utilisateur findUtilisateurByLogin(String login){
		try {
			return createdQueryWithOneParameter(Utilisateur.class,"login",login).getSingleResult();
		} catch (Exception ex){
			return null;
		}
	}

}
