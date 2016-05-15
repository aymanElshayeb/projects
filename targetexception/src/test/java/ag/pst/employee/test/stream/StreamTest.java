package ag.pst.employee.test.stream;

import java.util.ArrayList;
import java.util.Collection;
import java.util.List;
import java.util.stream.Collectors;

import org.junit.Assert;
import org.junit.Test;

public class StreamTest {

	@Test
	public void checkUniqueCurrency(){
		
	//please implement the missing logic
		//Here is the answer
		Collection<String> currencies =getKnownCountries().stream().map((x)->x.getCurrency()).distinct().collect(Collectors.toList()); //getKnownCountries() ...  each currency value only once, use java stream api

		;
		Assert.assertEquals(5, currencies.size());
		
	}
	
	
	List<Country> getKnownCountries(){
		ArrayList<Country> result = new ArrayList<>();
		
		result.add( new Country("DE","EUR") );
		result.add( new Country("BE","EUR") );
		result.add( new Country("ES","EUR") );
		result.add( new Country("GB", "GBP"));
		result.add( new Country("US", "USD"));
		result.add( new Country("AU", "AUD"));
		result.add( new Country("CH", "CHF"));
		
		return result;
	}
	
}


class Country {
	
	private final String iso2;
	private final String currency;
	
	public Country(String iso2, String currency){
		this.iso2 = iso2;
		this.currency = currency;
	}
	
	String getIso2(){
		return this.iso2;
	}
	
	String getCurrency(){
		return this.currency;
	}
}


