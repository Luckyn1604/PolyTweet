package j2e.domain.impl;


import java.util.HashSet;
import java.util.List;
import java.util.Set;

import j2e.domain.CanalFinder;
import j2e.domain.MessageFinder;
import j2e.entities.Canal;
import j2e.entities.Message;

import javax.ejb.EJB;
import javax.ejb.Stateless;
@Stateless
public class MessageFinderBean extends FinderBean implements MessageFinder {
	
	@EJB
	private CanalFinder canalFinder;
	
	public Message findMessageById(Long id) {
		try {
			return createdQueryWithOneParameter(Message.class,"id",id).getSingleResult();
		} catch (Exception ex){
			return null;
		}
	}

	public Set<Message> findMessageByTag(String tagCanal) {
        Canal canal = canalFinder.findCanalByTag(tagCanal);
        List<Message> messages = createdQueryWithOneParameter(Message.class, "canal", canal).getResultList();
        return new HashSet<Message>(messages);
	}
}
