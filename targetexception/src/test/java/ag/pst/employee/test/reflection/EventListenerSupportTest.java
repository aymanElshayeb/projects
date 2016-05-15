package ag.pst.employee.test.reflection;

import java.lang.reflect.InvocationHandler;
import java.lang.reflect.InvocationTargetException;
import java.lang.reflect.Method;

import org.junit.Test;

/**
 * To create proxy in java , we need to provide InvocationHandler implementation to the proxy . This InvocationHandler interface contains only one method "invoke".
 * when "invoke" method calls method that throws checked exception then Proxy will check if this exception exists in the InvocationHandler.invoke interface signature or not. 
 * if the exception doesn't exist, UndeclareExcpetion will be thrown. 
 * I have to override org.apache.commons.lang3.event.EventListenerSupport.createInvocationHandler  to provide new InvocationHandler interface that has "MyException" exception in its signature
 * another solution is to make "EnventListnerImp.onSomethingThrown" method throws Throwable exception instead of MyException.     
 * @author elshayeb
 *
 */
public class EventListenerSupportTest {
	
	/**
	 * This class extends EventListenerSupport to provide new InvocationHandler 
	 * @author elshayeb
	 *
	 * @param <L>
	 */
	private class EventListenerInvocationSupport<L> extends org.apache.commons.lang3.event.EventListenerSupport<L>{
		
		/**
		 * 
		 */
		private static final long serialVersionUID = 1L;


		public EventListenerInvocationSupport(final Class<L> listenerInterface) {
	        super(listenerInterface, Thread.currentThread().getContextClassLoader());
	    }
		
		 
	    protected InvocationHandler createInvocationHandler() {
	    	InvocationHandler invocationHandler= super.createInvocationHandler();
	        return new ProxyInvocationHandlerWithMyException(invocationHandler);
	    }

		 
	    protected class ProxyInvocationHandlerWithMyException implements InvocationHandler {
	    	
	    	
	    	InvocationHandler invocationHandler;
	    	
	        public ProxyInvocationHandlerWithMyException(
					InvocationHandler invocationHandler) {
	        	
	        		this.invocationHandler =invocationHandler;
	        	
			}

	        /**
	         * The invoke method here provides "MyException" in its signature
	         */
	        @Override
	        public Object invoke(final Object unusedProxy, final Method method, final Object[] args) throws Throwable, MyException {
	        	Object result =null;
	        	try{
	        		result= invocationHandler.invoke(unusedProxy, method, args);
	        	}catch ( InvocationTargetException  e){
	        		throw e.getTargetException();
	        	}
	        	return result;
	        }
	    }
	}
	
	



	/**
	 * Question 1: is my MyException thrown?
	 * Question 2: what can we do to got this up and running as expected?
	 * @throws MyException
	 */
	@Test(expected=MyException.class) 
	public void checkBugInApacheCommonsTest() throws MyException{
		
		
		
		
		EventListenerInvocationSupport<EventListener> eventListeners = new EventListenerInvocationSupport<EventListener>(EventListener.class);
		
		eventListeners.addListener(new EventListenerImpl());
		

		eventListeners.fire().onSomethingThrown();
		
	}

}
