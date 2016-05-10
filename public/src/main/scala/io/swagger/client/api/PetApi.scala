package io.swagger.client.api

import io.swagger.client.model.Pet
import java.io.File
import io.swagger.client.model.ApiResponse
import io.swagger.client.core._
import io.swagger.client.core.CollectionFormats._
import io.swagger.client.core.ApiKeyLocations._

object PetApi {

  /**
   * 
   * Expected answers:
   *   code 405 :  (Invalid input)
   * 
   * @param body Pet object that needs to be added to the store
   */
  def addPet(body: Pet): ApiRequest[Unit] =
    ApiRequest[Unit](ApiMethods.POST, "http://petstore.swagger.io/v2", "/pet", "application/json")
      .withBody(body)
      .withErrorResponse[Unit](405)
      
  /**
   * 
   * Expected answers:
   *   code 400 :  (Invalid ID supplied)
   *   code 404 :  (Pet not found)
   * 
   * @param petId Pet id to delete
   * @param apiKey 
   */
  def deletePet(petId: Long, apiKey: Option[String] = None): ApiRequest[Unit] =
    ApiRequest[Unit](ApiMethods.DELETE, "http://petstore.swagger.io/v2", "/pet/{petId}", "application/json")
      .withPathParam("petId", petId)
      .withHeaderParam("api_key", apiKey)
      .withErrorResponse[Unit](400)
      .withErrorResponse[Unit](404)
      
  /**
   * Multiple status values can be provided with comma separated strings
   * 
   * Expected answers:
   *   code 200 : Seq[Pet] (successful operation)
   *   code 400 :  (Invalid status value)
   * 
   * @param status Status values that need to be considered for filter
   */
  def findPetsByStatus(status: Seq[String]): ApiRequest[Seq[Pet]] =
    ApiRequest[Seq[Pet]](ApiMethods.GET, "http://petstore.swagger.io/v2", "/pet/findByStatus", "application/json")
      .withQueryParam("status", ArrayValues(status, MULTI))
      .withSuccessResponse[Seq[Pet]](200)
      .withErrorResponse[Unit](400)
      
  /**
   * Muliple tags can be provided with comma separated strings. Use tag1, tag2, tag3 for testing.
   * 
   * Expected answers:
   *   code 200 : Seq[Pet] (successful operation)
   *   code 400 :  (Invalid tag value)
   * 
   * @param tags Tags to filter by
   */
  def findPetsByTags(tags: Seq[String]): ApiRequest[Seq[Pet]] =
    ApiRequest[Seq[Pet]](ApiMethods.GET, "http://petstore.swagger.io/v2", "/pet/findByTags", "application/json")
      .withQueryParam("tags", ArrayValues(tags, MULTI))
      .withSuccessResponse[Seq[Pet]](200)
      .withErrorResponse[Unit](400)
      
  /**
   * Returns a single pet
   * 
   * Expected answers:
   *   code 200 : Pet (successful operation)
   *   code 400 :  (Invalid ID supplied)
   *   code 404 :  (Pet not found)
   * 
   * Available security schemes:
   *   api_key (apiKey)
   * 
   * @param petId ID of pet to return
   */
  def getPetById(petId: Long)(implicit apiKey: ApiKeyValue): ApiRequest[Pet] =
    ApiRequest[Pet](ApiMethods.GET, "http://petstore.swagger.io/v2", "/pet/{petId}", "application/json")
      .withApiKey(apiKey, "api_key", HEADER)
      .withPathParam("petId", petId)
      .withSuccessResponse[Pet](200)
      .withErrorResponse[Unit](400)
      .withErrorResponse[Unit](404)
      
  /**
   * 
   * Expected answers:
   *   code 400 :  (Invalid ID supplied)
   *   code 404 :  (Pet not found)
   *   code 405 :  (Validation exception)
   * 
   * @param body Pet object that needs to be added to the store
   */
  def updatePet(body: Pet): ApiRequest[Unit] =
    ApiRequest[Unit](ApiMethods.PUT, "http://petstore.swagger.io/v2", "/pet", "application/json")
      .withBody(body)
      .withErrorResponse[Unit](400)
      .withErrorResponse[Unit](404)
      .withErrorResponse[Unit](405)
      
  /**
   * 
   * Expected answers:
   *   code 405 :  (Invalid input)
   * 
   * @param petId ID of pet that needs to be updated
   * @param name Updated name of the pet
   * @param status Updated status of the pet
   */
  def updatePetWithForm(petId: Long, name: Option[String] = None, status: Option[String] = None): ApiRequest[Unit] =
    ApiRequest[Unit](ApiMethods.POST, "http://petstore.swagger.io/v2", "/pet/{petId}", "application/x-www-form-urlencoded")
      .withFormParam("name", name)
      .withFormParam("status", status)
      .withPathParam("petId", petId)
      .withErrorResponse[Unit](405)
      
  /**
   * 
   * Expected answers:
   *   code 200 : ApiResponse (successful operation)
   * 
   * @param petId ID of pet to update
   * @param additionalMetadata Additional data to pass to server
   * @param file file to upload
   */
  def uploadFile(petId: Long, additionalMetadata: Option[String] = None, file: Option[File] = None): ApiRequest[ApiResponse] =
    ApiRequest[ApiResponse](ApiMethods.POST, "http://petstore.swagger.io/v2", "/pet/{petId}/uploadImage", "multipart/form-data")
      .withFormParam("additionalMetadata", additionalMetadata)
      .withFormParam("file", file)
      .withPathParam("petId", petId)
      .withSuccessResponse[ApiResponse](200)
      


}

