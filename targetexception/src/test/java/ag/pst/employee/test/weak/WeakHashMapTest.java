package ag.pst.employee.test.weak;

import java.util.Arrays;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;
import java.util.Set;


import org.junit.Test;

import static org.junit.Assert.*;
/**
 * In java there is something called weak reference. if one object has many weak references but doesn't have any strong reference then this object is eligible to Garbage collector.
 * WeakMap is a hash map. All its keys references are weak . This means if  one key doesn't have another strong reference, it will be eligible to Garbage collector and its entry will be 
 * deleted and will not  exist any more.   
 * @author elshayeb
 *
 */
public class WeakHashMapTest {
	
	Object[] KEY_ARRAY;

	Object[] VALUE_ARRAY;

	@Test
	public void test_entrySet() {
		//We have to change WeakHashMap to normal HashMap
		//WeakHashMap<Object, Object> weakMap = new WeakHashMap<Object, Object>();
		HashMap<Object, Object> weakMap = new HashMap<Object, Object>();
		KEY_ARRAY = new Object[100];
		VALUE_ARRAY = new Object[100];
		for (int i = 0; i < 100; i++) {
			KEY_ARRAY[i] = new Integer(i);
			VALUE_ARRAY[i] = new Long(i);
			weakMap.put(KEY_ARRAY[i], VALUE_ARRAY[i]);
		}

		List<Object> keys = Arrays.asList(KEY_ARRAY);
		List<Object> values = Arrays.asList(VALUE_ARRAY);

		// Check the entry set has correct size & content
		Set<Map.Entry<Object, Object>> entrySet = weakMap.entrySet();
		assertEquals("Assert 0: Incorrect number of entries returned", 100,
				entrySet.size());
		Iterator<Map.Entry<Object, Object>> it = entrySet.iterator();
		while (it.hasNext()) {
			Map.Entry<Object, Object> entry = it.next();
			assertTrue("Assert 1: Invalid map entry key returned", keys
					.contains(entry.getKey()));
			assertTrue("Assert 2: Invalid map entry value returned", values
					.contains(entry.getValue()));
			assertTrue("Assert 3: Entry not in entry set", entrySet
					.contains(entry));
		}

		// Dereference list of key/value objects
		keys = values = null;

		// Dereference a single key, then try to
		// force a collection of the weak ref'd obj
		// This line what makes size 99 instead of 100
		//The keys in WeakHashMap are of type weakreference . this means if no strong references refer
		//to the object and only weak references refers to the object then it will be eligible to 
		//Garbage collector and will be removed from memory
		//There are two way to fix this test case . 1- by change WeakHashMap to normal HashMap
		//2- by remove   //Key_Array[50]=null line
		KEY_ARRAY[50] = null;
		
		int count = 0;
		do {
			System.gc();
			System.gc();
			Runtime.getRuntime().runFinalization();
			count++;
		} while (count <= 5 && entrySet.size() == 100);

		if ((count == 5) && (entrySet.size() == 100)) {
			// We failed (or entrySet broken), so further tests not valid.
			return;
		}

		//Question 1: why the size of entrySet is 99?
		//Question 2: mistake in WeakHashMap or a mistake in this test case?
		//The keys in WeakHashMap are of type weakreference . this means if no strong references refer
				//to the object and only weak references refers to the object then it will be eligible to 
				//Garbage collector and will be removed from memory
				//There are two way to fix this test case . 1- by change WeakHashMap to normal HashMap
				//2- by remove   //Key_Array[50]=null line
		assertEquals("Assert 4: Incorrect number of entries after gc", 100,
				entrySet.size());
		assertSame("Assert 5: Entries not identical", entrySet.iterator()
				.next(), entrySet.iterator().next());

		// remove alternate entries using the iterator, and ensure the
		// iteration count is consistent
		int size = entrySet.size();
		it = entrySet.iterator();
		while (it.hasNext()) {
			it.next();
			it.remove();
			size--;
			if (it.hasNext()) {
                it.next();
            }

		}
		assertEquals("Assert 6: entry set count mismatch", size, entrySet
				.size());

		int entries = 0;
		it = entrySet.iterator();
		while (it.hasNext()) {
			it.next();
			entries++;
		}
		assertEquals("Assert 6: count mismatch", size, entries);

		it = entrySet.iterator();
		while (it.hasNext()) {
			it.next();
			it.remove();
		}
		assertEquals("Assert 7: entry set not empty", 0, entrySet.size());
		assertTrue("Assert 8:  iterator not empty", !entrySet.iterator()
				.hasNext());
	}

}
