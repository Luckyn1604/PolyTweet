package j2e.domain.impl;

import java.util.HashSet;
import java.util.Set;

import j2e.application.TypeCanal;
import j2e.domain.CanalFinder;
import j2e.domain.UtilisateurFinder;
import j2e.domain.UtilisateurManager;
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
public class UtilisateurManagerBean implements UtilisateurManager {

	 @PersistenceContext(unitName = "polytweet-pu")
	    EntityManager entityManager;

	    @EJB
	    UtilisateurFinder finder;
	    
	    @EJB
	    CanalFinder canalFinder;

	    public boolean delete(String login) {
	        Utilisateur utilisateur = finder.findUtilisateurByLogin(login);
	        if (utilisateur != null){
	            entityManager.remove(utilisateur);
	            return true;
	        }
	        return false;
	    }

	    public Utilisateur create(String login) {
	        Utilisateur utilisateur = finder.findUtilisateurByLogin(login);
	        if (utilisateur == null){
	            utilisateur = new Utilisateur(login);
	            entityManager.persist(utilisateur);
	        }
	        return utilisateur;
	    }
	    
	    public boolean demandeAbonnement(Utilisateur utilisateur, String tagCanal) {
	            Canal canal = canalFinder.findCanalByTag(tagCanal);
	            entityManager.merge(utilisateur);
	            for(Canal c : utilisateur.getCanalAbonnes()) 
	            	if(c.equals(canal)) 
	            		return false;
	            for(Canal c : utilisateur.getCanalAttente())
	            	if(c.equals(canal))
	            		return false;
	            canal.demanderAbonnement(utilisateur);

	            entityManager.merge(utilisateur);
	            entityManager.merge(canal);
	            return true;
	    }
	    
	    public boolean accepterAbonnement(Utilisateur donneur,Utilisateur receveur, String tagCanal){
	    	Canal canal = canalFinder.findCanalByTag(tagCanal);
            entityManager.merge(donneur);
            entityManager.merge(receveur);
            boolean donneurModerateur = false;
            boolean receveurAttente = false;
            for(Canal c : donneur.getCanalModerateurs()) 
            	if(c.equals(canal)) 
            		donneurModerateur=true;
            for(Canal c : receveur.getCanalAttente())
            	if(c.equals(canal))
            		receveurAttente = true;
            
            if(receveurAttente && donneurModerateur){
					donneur.accepterAbonne(receveur,canal);
					entityManager.merge(receveur);
					entityManager.merge(canal);
					return true;
            }
	    	return false;	    	
	    }
	    
	    public boolean refuserAbonnement(Utilisateur donneur,Utilisateur receveur, String tagCanal){
	    	Canal canal = canalFinder.findCanalByTag(tagCanal);
            entityManager.merge(donneur);
            entityManager.merge(receveur);
            boolean donneurModerateur = false;
            boolean receveurAttente = false;
            for(Canal c : donneur.getCanalModerateurs()) 
            	if(c.equals(canal)) 
            		donneurModerateur=true;
            for(Canal c : receveur.getCanalAttente())
            	if(c.equals(canal))
            		receveurAttente = true;
            
            if(receveurAttente && donneurModerateur){
					donneur.refuserAbonne(receveur,canal);
					entityManager.merge(receveur);
					entityManager.merge(canal);
					return true;
            }
	    	return false;	    	
	    }
	    
	    public boolean ajouterModerateur(Utilisateur donneur,Utilisateur receveur, String tagCanal){	    	
	    	Canal canal = canalFinder.findCanalByTag(tagCanal);
            entityManager.merge(donneur);
            entityManager.merge(receveur);
            
            for(Canal c : receveur.getCanalModerateurs())
            	if(c.equals(canal))
            		return false;
            
            for(Canal c : donneur.getCanalModerateurs()) 
            	if(c.equals(canal)) 
            	{
            		donneur.ajouterModerateur(receveur,canal);
					entityManager.merge(receveur);
					entityManager.merge(canal);
					return true;
            	}

	    	return false;
	    }
	    
	    public boolean supprimerModerateur(Utilisateur donneur,Utilisateur receveur, String tagCanal){
	    	Canal canal = canalFinder.findCanalByTag(tagCanal);
            entityManager.merge(donneur);
            entityManager.merge(receveur);
            boolean donneurProprietaire = false;
            boolean receveurModerateur = false;
            for(Canal c : donneur.getCanalProprietaires()) 
            	if(c.equals(canal)) 
            		donneurProprietaire=true;
            for(Canal c : receveur.getCanalModerateurs())
            	if(c.equals(canal))
            		receveurModerateur= true;
            
            if(donneurProprietaire && receveurModerateur){
					donneur.supprimerModerateur(receveur,canal);
					entityManager.merge(receveur);
					entityManager.merge(canal);
					return true;
            }
	    	return false;
	    }
	    
	    public boolean ajouterProprietaire(Utilisateur donneur,Utilisateur receveur, String tagCanal){
	    	Canal canal = canalFinder.findCanalByTag(tagCanal);
            entityManager.merge(donneur);
            entityManager.merge(receveur);
            for(Canal c : receveur.getCanalProprietaires())
            	if(c.equals(canal))
            		return false;
            for(Canal c : donneur.getCanalProprietaires()) 
            	if(c.equals(canal)) 
            	{
					donneur.ajouterProprietaire(receveur,canal);
					entityManager.merge(receveur);
					entityManager.merge(canal);
					return true;
            	}
	    	return false;
	    }
	    
	    public boolean supprimerProprietaire(Utilisateur donneur,Utilisateur receveur, String tagCanal){
	    	Canal canal = canalFinder.findCanalByTag(tagCanal);
            entityManager.merge(donneur);
            entityManager.merge(receveur);
            boolean receveurProprietaire = false;
            boolean donneurProprietaire = false;
            for(Canal c : receveur.getCanalProprietaires())
            	if(c.equals(canal))
            		receveurProprietaire = true;
            for(Canal c : donneur.getCanalProprietaires()) 
            	if(c.equals(canal)) 
            		donneurProprietaire = true;
            
            if (donneurProprietaire && receveurProprietaire)
            {
            	donneur.supprimerProprietaire(receveur,canal);
            	entityManager.merge(receveur);
            	entityManager.merge(canal);
            	return true;
            }
	    	return false;
	    }

	    public boolean ajouterMessage(Utilisateur utilisateur, Message message, String tagCanal){
            Canal canal = canalFinder.findCanalByTag(tagCanal);
            entityManager.merge(utilisateur);
            for(Message m : canal.getMessages())
            	if (m.equals(message))
            		return false;
            for(Canal c : utilisateur.getCanalAbonnes()) 
            	if(c.equals(canal)) 
            	{
            		utilisateur.ajouterMessage(message, canal);
            		entityManager.merge(utilisateur);
            		entityManager.merge(canal);
            		return true;
            	}
            return false;
	    }
	    
	    public boolean supprimerMessage(Utilisateur utilisateur, Message message, String tagCanal){
	    	Canal canal = canalFinder.findCanalByTag(tagCanal);
            entityManager.merge(utilisateur);
            boolean messageExiste = false;
            boolean utilisateurSupprime = false;
            for (Message m : canal.getMessages())
            	if (m.equals(message))
            		messageExiste = true;
            for (Canal c : utilisateur.getCanalModerateurs())
            	if (c.equals(canal))
            		utilisateurSupprime = true;
            if (message.getAuteur().equals(utilisateur))
            	utilisateurSupprime = true;
            
            if(messageExiste && utilisateurSupprime){
					utilisateur.supprimerMessage(message, canal);
					entityManager.remove(message);
					entityManager.merge(canal);
					entityManager.merge(utilisateur);
					return true;
            }
	    	return false;
	    }
	    
	    public Set<Message> consulterMessages(Utilisateur utilisateur, String tagCanal){
	    	Set<Message> messages = new HashSet<Message>();
            Canal canal = canalFinder.findCanalByTag(tagCanal);
            entityManager.merge(utilisateur);
            boolean abonne = false;
            for(Canal c : utilisateur.getCanalAbonnes()) 
            	if(c.equals(canal)) 
            		abonne=true;
            if((!abonne) && canal.getType()==TypeCanal.PRIVE) return messages;
            
            messages = utilisateur.consulterMessages(canal);

            entityManager.merge(utilisateur);
            entityManager.merge(canal);
            return messages;
	    }
	    
	    public boolean supprimerCanal(Utilisateur utilisateur, String tagCanal){
	    	Canal canal = canalFinder.findCanalByTag(tagCanal);
	    	entityManager.merge(utilisateur);
	    	for(Canal c : utilisateur.getCanalProprietaires())
	    		if(c.equals(canal))
	    		{
	    			entityManager.remove(canal);
	    			entityManager.merge(utilisateur);
	    			return true;
	    		}
	    	return false;
	    }
}
