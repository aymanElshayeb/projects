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
	 * To solve this issue ,  i have deleted the Dummy class from the main project then i have added Dummy class in another place than main project path 
	 * then i have loaded the class by new loader each time . These new loaders are siblings and have the same parent loader.
	 * To make this test case work , please copy "source" folder which exists in main folder in the project to "c:" directly
	 * @throws Exception
	 */
	@Test
	public void loadMultipleTimesTest( ) throws Exception{
		
		Set<Class<?>> loadedClasses = new HashSet<>();
		
		
		//1
		try{
			URL url = new File("C:\\source").toURI().toURL();
			URLClassLoader cl = new URLClassLoader( new URL[]{url} );
			Object d = cl.loadClass("ag.pst.employee.test.classloading.Dummy").newInstance();
			Assert.assertNotNull(d);
			loadedClasses.add(d.getClass());
			cl.close();
		}catch(Exception e){
			e.printStackTrace();
		}


		Thread.sleep(1000);
		
		//2
		try{
			URL url = new File("C:\\source").toURI().toURL();
			URLClassLoader cl = new URLClassLoader( new URL[]{url} );
			Object d = cl.loadClass("ag.pst.employee.test.classloading.Dummy").newInstance();
			Assert.assertNotNull(d);
			loadedClasses.add(d.getClass());
			cl.close();
		}catch(Exception e){
			e.printStackTrace();
		}
		

		Thread.sleep(1000);
		
		//3
		try{
			URL url = new File("C:\\source").toURI().toURL();
			URLClassLoader cl = new URLClassLoader( new URL[]{url} );
			Object d = cl.loadClass("ag.pst.employee.test.classloading.Dummy").newInstance();
			Assert.assertNotNull(d);
			loadedClasses.add(d.getClass());
			cl.close();
		}catch(Exception e){
			e.printStackTrace();
		}
		
		Assert.assertEquals(3, loadedClasses.size());
	}



}
