package demo;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.firefox.FirefoxDriver;

public class Selenium {

	public static void main(String[] args) throws InterruptedException {
		// Set driver
		//System.setProperty("webdriver.chrome.driver","C:\\Users\\User\\Downloads\\chromedriver_win32\\chromedriver.exe");
		System.setProperty("webdriver.gecko.driver","C:\\Users\\User\\Downloads\\geckodriver-v0.18.0-win64\\geckodriver.exe");
		//System.setProperty("webdriver.gecko.driver","C:\\Users\\User\\Downloads\\geckodriver-v0.19.1-win32\\geckodriver.exe");
		//System.setProperty("webdriver.firefox.marionette","C:\\geckodriver.exe");
		 WebDriver driver; 
		//driver = new ChromeDriver();
		
		 System.out.println("launch facebook");
	     driver = new FirefoxDriver();
	     driver.navigate().to("https://identity.tele2.se/login?client_id=t2b_selfservice_web&scope=openid&state=qynp4R1aDaLwQGrNxEgc7A%3d%3d-DtEy0Xbgfc%2fiU5C%2flPu9xCWh28prhb4KcTuq0xAOgjD6B61VJ16acULwIRQ3tAi00gLJXXLdu9bk%2ftHRITYzzVie20olXt4PEi%2fPlZPeg%2bcNGQCkUwiglwQhzhndFdzBC%2fNixEpsT7TSCCZOOqOu9oQR1L5B44vQR7JFhPvDa7oXzfrgsa5PoqFz0qIaMZMpH5HVe2Koc%2fMSR0MnyZEgWyLpuxTx5HgSo6cNSoHDu6b3TCQlxFr1%2fj6T%2bUs0nwF%2fqSoZw65lDe18h%2f3aUGlqnFIgE5R06fjlhShCgXxZwKUAI9UQ5aAEJzZpxaFm4OnNwKo6Z44Dncr89V4K9dcHTT5pNWbztNk9bjg5fHjMNUHBc%2f1CmpeXEpciI5aLHIkkigIAWkoTXE5ILHnUxt1FQGckByoimXHlXPiZNhimiUo2%2bGRLJ9%2fVa5muXn0hafjii61RM3Ltt5j12EDWAUm2nQqF7MX6JLzY%2fn5YVutelgP6BUoFWTp%2bIN5YIQJzjEJq");
		 //driver.navigate().to("http://www.facebook.com");
		driver.manage().window().maximize();
	    Thread.sleep(4000);
	   // driver.findElement(By.name("email")).sendKeys("zagaga@hotmail.com");
	    
	   // driver.findElement(By.name("pass")).sendKeys("lalala@123");
	   // driver.findElement(By.cssSelector("#u_0_y")).submit();
	    Thread.sleep(3000);
	   // driver.navigate().back();
	    driver.close();
	    
	    
		
	}

}
