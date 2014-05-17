package j2e.domain;

import javax.jws.WebService;

import j2e.entities.Canal;
import j2e.entities.Message;
import j2e.entities.Utilisateur;

@WebService
public interface MessageManager {
	public boolean delete(long id);
	public Message create(String texte, Canal canal, Utilisateur auteur);
}
