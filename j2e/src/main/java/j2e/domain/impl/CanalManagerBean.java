package j2e.domain.impl;

import java.util.HashSet;
import java.util.Set;

import j2e.application.TypeCanal;
import j2e.domain.CanalFinder;
import j2e.domain.CanalManager;
import j2e.domain.MessageFinder;
import j2e.domain.UtilisateurFinder;
import j2e.entities.Canal;
import j2e.entities.Message;
import j2e.entities.Utilisateur;

import javax.ejb.EJB;
import javax.ejb.Stateless;
import javax.jws.WebService;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;

@Stateless
@WebService
public class CanalManagerBean implements CanalManager {

	@PersistenceContext(unitName = "polytweet-pu")
	EntityManager entityManager;

    @EJB
    UtilisateurFinder utilisateurFinder;
    
    @EJB
    CanalFinder canalFinder;
    
    @EJB
    MessageFinder messageFinder;

	public boolean supprimer(String tag) {
		Canal canal = canalFinder.findCanalByTag(tag);
		if (canal != null){
			entityManager.remove(canal);
			return true;
		}
		return false;
	}

	
	public String creer(String tag, String typeCanal, String proprietaireLogin) {
		Canal canal = canalFinder.findCanalByTag(tag);
		Utilisateur proprietaire = null;
		if (canal == null) {
			proprietaire = utilisateurFinder.findUtilisateurByLogin(proprietaireLogin);
			canal = new Canal(tag,TypeCanal.valueOf(typeCanal),proprietaire);
			
			proprietaire.getCanalProprietaires().add(canal);
			proprietaire.getCanalModerateurs().add(canal);
			proprietaire.getCanalAbonnes().add(canal);
			entityManager.persist(canal);
			entityManager.persist(proprietaire);
		}
		
		return tag;
	}

	
	public boolean ajouterMessage(long messageID, String tagCanal){
		Message message = messageFinder.findMessageById(messageID);
		Canal canal = canalFinder.findCanalByTag(tagCanal);
		canal.ajouterMessage(message);
		entityManager.merge(canal);
		return true;
	}

	
	public boolean supprimerMessage(long messageID, String tagCanal){
		Message message = messageFinder.findMessageById(messageID);
		Canal canal = canalFinder.findCanalByTag(tagCanal);
		if(message !=null){
			canal.supprimerMessage(message);
			entityManager.remove(message);
		}
		return true;
	}


	public Set<String> afficherTagByAbonne(String abonneLogin) {
		Set<String> set = new HashSet<String>();
		for (Canal c : canalFinder.findCanalByAbonne(abonneLogin)) set.add(c.getTag());
		return set;
	}


	public Set<String> afficherTagByType(String typeCanal) {
		Set<String> set = new HashSet<String>();
		for (Canal c : canalFinder.findCanalByType(typeCanal)) set.add(c.getTag());
		return set;
	}

}
