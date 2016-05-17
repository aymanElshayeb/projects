package ag.pst.employee.test.classloading;


import java.io.File;
import java.net.URL;
import java.net.URLClassLoader;
import java.util.HashSet;
import java.util.Set;

import org.junit.Assert;
import org.junit.Test;

public class ClassLoadTest {


	/**
	 * Question: how to load class Dummy multiple times?
	 * Answer:
	 *  Java loads the bit codes in JVM dynamically. Java uses different loaders to load codes. the Loaders have a tree structure. if Loader in some node can't find certain class or resource, 
	 *  ,it searches for it in its parent loader. 
	 *  The main issue in this test case is that the Dummy class  already exists and is loaded by current Thread  loader. 
	 *  The current thread  loader is a parent loader of each new class loader created in test case.
	 * so each time new loader try to load Dummy class. It searches for the class in the Current Thread  loader and returns the same class back. 
	 * 
	 * To solve this issue ,  I have gotten the parent loader of the Dummy Class then i have loaded the Dummy Class with 3 new loaders that have the same parent of the Dummy
	 * By this way, When new loaders search of the dummy class it can't find it at parent because they are sibling of the same parent
	 * @throws Exception
	 */
	@Test
	public void loadMultipleTimesTest( ) throws Exception{
		
		Set<Class<?>> loadedClasses = new HashSet<>();
		
		Dummy dummy= new Dummy();
		
		
		//1
		try{
			URL url = dummy.getClass().getResource("/");
			URLClassLoader cl = new URLClassLoader( new URL[]{url},dummy.getClass().getClassLoader().getParent() );
			Object d = cl.loadClass(Dummy.class.getName()).newInstance();
			Assert.assertNotNull(d);
			loadedClasses.add(d.getClass());
			cl.close();
		}catch(Exception e){
			e.printStackTrace();
		}


		Thread.sleep(1000);
		
		//2
		try{
			URL url = dummy.getClass().getResource("/");
			URLClassLoader cl = new URLClassLoader( new URL[]{url},dummy.getClass().getClassLoader().getParent() );
			Object d = cl.loadClass(Dummy.class.getName()).newInstance();
			Assert.assertNotNull(d);
			loadedClasses.add(d.getClass());
			cl.close();
		}catch(Exception e){
			e.printStackTrace();
		}
		

		Thread.sleep(1000);
		
		//3
		try{
			URL url = dummy.getClass().getResource("/");
			URLClassLoader cl = new URLClassLoader( new URL[]{url},dummy.getClass().getClassLoader().getParent() );
			Object d = cl.loadClass(Dummy.class.getName()).newInstance();
			Assert.assertNotNull(d);
			loadedClasses.add(d.getClass());
			cl.close();
		}catch(Exception e){
			e.printStackTrace();
		}
		
		Assert.assertEquals(3, loadedClasses.size());
	}



}
