package j2e.domain.impl;


import j2e.application.TypeCanal;
import j2e.domain.CanalFinder;
import j2e.domain.UtilisateurFinder;
import j2e.entities.Canal;
import j2e.entities.Utilisateur;

import java.util.HashSet;
import java.util.List;
import java.util.Set;

import javax.ejb.EJB;
import javax.ejb.Stateless;
import javax.jws.WebService;



@Stateless
@WebService
public class CanalFinderBean extends FinderBean implements CanalFinder  {

	  @EJB
	    private UtilisateurFinder utilisateurFinder;

	    
	    public Set<Canal> findCanalByProprietaire(String login) {
	        Utilisateur utilisateur = utilisateurFinder.findUtilisateurByLogin(login);
	        List<Canal> canaux = createdQueryWithOneParameter(Canal.class, "proprietaires",utilisateur).getResultList();
	        return new HashSet<Canal>(canaux);
	    }
	
	
	public Canal findCanalByTag(String tag) {
		try {
			return createdQueryWithOneParameter(Canal.class, "tag", tag).getSingleResult();
		} catch (Exception ex){
			return null;
		}
	}


	public Set<Canal> findCanalByType(TypeCanal type) {
		try {
			return new HashSet<Canal>(createdQueryWithOneParameter(Canal.class, "type", type).getResultList());
		} catch (Exception ex){
			return null;
		}
	}


	public Set<Canal> findCanalByAbonne(String login) {
        Utilisateur utilisateur = utilisateurFinder.findUtilisateurByLogin(login);
        List<Canal> canaux = createdQueryWithOneParameter(Canal.class, "abonnes",utilisateur).getResultList();
        return new HashSet<Canal>(canaux);
	}
}
