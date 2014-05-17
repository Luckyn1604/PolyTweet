package j2e.domain;

import javax.jws.WebService;

import j2e.application.TypeCanal;
import j2e.entities.Canal;
import j2e.entities.Message;

@WebService
public interface CanalManager {
	
	public boolean supprimer(String tag);
	public Canal creer(String tag,TypeCanal type, String proprietaireId);
	public boolean ajouterMessage(Message message, Canal canal);
	

}
