package j2e.domain;

import javax.jws.WebService;

@WebService
public interface MessageManager {
	public boolean delete(long id);
	public long create(String texte, String canal, String auteur);
}
