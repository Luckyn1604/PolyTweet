package j2e.domain;

import java.util.Set;

import javax.jws.WebService;

import j2e.entities.Canal;

@WebService
public interface CanalFinder {
	public Set<Canal> findCanalByProprietaire(String login);
	public Canal findCanalByTag(String tag);
	public Set<Canal> findCanalByType(String type);
	public Set<Canal> findCanalByAbonne(String login);

}
