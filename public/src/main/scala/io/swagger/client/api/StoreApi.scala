package io.swagger.client.api

import io.swagger.client.model.Order
import io.swagger.client.core._
import io.swagger.client.core.CollectionFormats._
import io.swagger.client.core.ApiKeyLocations._

object StoreApi {

  /**
   * For valid response try integer IDs with positive integer value. Negative or non-integer values will generate API errors
   * 
   * Expected answers:
   *   code 400 :  (Invalid ID supplied)
   *   code 404 :  (Order not found)
   * 
   * @param orderId ID of the order that needs to be deleted
   */
  def deleteOrder(orderId: Long): ApiRequest[Unit] =
    ApiRequest[Unit](ApiMethods.DELETE, "http://petstore.swagger.io/v2", "/store/order/{orderId}", "application/json")
      .withPathParam("orderId", orderId)
      .withErrorResponse[Unit](400)
      .withErrorResponse[Unit](404)
      
  /**
   * Returns a map of status codes to quantities
   * 
   * Expected answers:
   *   code 200 : Map[String, Int] (successful operation)
   * 
   * Available security schemes:
   *   api_key (apiKey)
   */
  def getInventory()(implicit apiKey: ApiKeyValue): ApiRequest[Map[String, Int]] =
    ApiRequest[Map[String, Int]](ApiMethods.GET, "http://petstore.swagger.io/v2", "/store/inventory", "application/json")
      .withApiKey(apiKey, "api_key", HEADER)
      .withSuccessResponse[Map[String, Int]](200)
      
  /**
   * For valid response try integer IDs with value &gt;= 1 and &lt;= 10. Other values will generated exceptions
   * 
   * Expected answers:
   *   code 200 : Order (successful operation)
   *   code 400 :  (Invalid ID supplied)
   *   code 404 :  (Order not found)
   * 
   * @param orderId ID of pet that needs to be fetched
   */
  def getOrderById(orderId: Long): ApiRequest[Order] =
    ApiRequest[Order](ApiMethods.GET, "http://petstore.swagger.io/v2", "/store/order/{orderId}", "application/json")
      .withPathParam("orderId", orderId)
      .withSuccessResponse[Order](200)
      .withErrorResponse[Unit](400)
      .withErrorResponse[Unit](404)
      
  /**
   * 
   * Expected answers:
   *   code 200 : Order (successful operation)
   *   code 400 :  (Invalid Order)
   * 
   * @param body order placed for purchasing the pet
   */
  def placeOrder(body: Order): ApiRequest[Order] =
    ApiRequest[Order](ApiMethods.POST, "http://petstore.swagger.io/v2", "/store/order", "application/json")
      .withBody(body)
      .withSuccessResponse[Order](200)
      .withErrorResponse[Unit](400)
      


}

