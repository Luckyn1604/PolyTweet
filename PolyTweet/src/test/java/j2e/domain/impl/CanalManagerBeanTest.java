package j2e.domain.impl;

import j2e.application.TypeCanal;
import j2e.domain.CanalFinder;
import j2e.domain.CanalManager;
import j2e.entities.Canal;
import j2e.entities.Utilisateur;

import javax.ejb.EJB;

import org.jboss.arquillian.container.test.api.Deployment;
import org.jboss.arquillian.junit.Arquillian;
import org.jboss.shrinkwrap.api.Archive;
import org.jboss.shrinkwrap.api.ShrinkWrap;
import org.jboss.shrinkwrap.api.asset.EmptyAsset;
import org.jboss.shrinkwrap.api.spec.WebArchive;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import org.junit.runner.RunWith;




@RunWith(Arquillian.class)
public class CanalManagerBeanTest {
	
	 @EJB
	 private CanalManager canalManager;

	 @EJB
	 private CanalFinder canalFinder;
	 
	 private Utilisateur utilisateur;
	 private Canal canal;

	@Deployment
    public static Archive<?> createDeployment() {
        return ShrinkWrap.create(WebArchive.class, "test.war")
                .addAsWebInfResource(EmptyAsset.INSTANCE, "beans.xml")
                .addAsWebInfResource("META-INF/persistence.xml", "persistence.xml")
                .addPackage(CanalManager.class.getPackage())
                .addPackage(CanalManagerBean.class.getPackage());
    }
	
	@Before
    public void setUp() throws Exception {
		
    }

    @Test
    public void testCreate() throws Exception {
    	utilisateur = new Utilisateur("test");
        canal = canalManager.creer("tag",TypeCanal.PUBLIC,utilisateur);
    	//assertNull(canalFinder.findCanalByTag("tag"));
    	//assertEquals(canal.getTag(),"tag");
    	//canalFinder.findCanalByTag("tag");
    	//assertEquals(found,canal);
    }


    @After
    public void clean() throws Exception {
       // canalManager.supprimer("tag");
    }

}