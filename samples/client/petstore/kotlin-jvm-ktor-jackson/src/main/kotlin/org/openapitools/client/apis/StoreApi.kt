/**
 *
 * Please note:
 * This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * Do not edit this file manually.
 *
 */

@file:Suppress(
    "ArrayInDataClass",
    "EnumEntryName",
    "RemoveRedundantQualifierName",
    "UnusedImport"
)

package org.openapitools.client.apis

import org.openapitools.client.models.Order

import org.openapitools.client.infrastructure.*
import io.ktor.client.HttpClientConfig
import io.ktor.client.request.forms.formData
import io.ktor.client.engine.HttpClientEngine
import io.ktor.http.ParametersBuilder
import com.fasterxml.jackson.databind.ObjectMapper

    open class StoreApi(
    baseUrl: String = ApiClient.BASE_URL,
    httpClientEngine: HttpClientEngine? = null,
    httpClientConfig: ((HttpClientConfig<*>) -> Unit)? = null,
    jsonBlock: ObjectMapper.() -> Unit = ApiClient.JSON_DEFAULT,
    ) : ApiClient(baseUrl, httpClientEngine, httpClientConfig, jsonBlock) {

        /**
        * Delete purchase order by ID
        * For valid response try integer IDs with value &lt; 1000. Anything above 1000 or nonintegers will generate API errors
         * @param orderId ID of the order that needs to be deleted 
         * @return void
        */
        open suspend fun deleteOrder(orderId: kotlin.String): HttpResponse<Unit> {

            val localVariableAuthNames = listOf<String>()

            val localVariableBody = 
                    io.ktor.client.utils.EmptyContent

            val localVariableQuery = mutableMapOf<String, List<String>>()

            val localVariableHeaders = mutableMapOf<String, String>()

            val localVariableConfig = RequestConfig<kotlin.Any?>(
            RequestMethod.DELETE,
            "/store/order/{orderId}".replace("{" + "orderId" + "}", "$orderId"),
            query = localVariableQuery,
            headers = localVariableHeaders
            )

            return request(
            localVariableConfig,
            localVariableBody,
            localVariableAuthNames
            ).wrap()
            }

        /**
        * Returns pet inventories by status
        * Returns a map of status codes to quantities
         * @return kotlin.collections.Map<kotlin.String, kotlin.Int>
        */
            @Suppress("UNCHECKED_CAST")
        open suspend fun getInventory(): HttpResponse<kotlin.collections.Map<kotlin.String, kotlin.Int>> {

            val localVariableAuthNames = listOf<String>("api_key")

            val localVariableBody = 
                    io.ktor.client.utils.EmptyContent

            val localVariableQuery = mutableMapOf<String, List<String>>()

            val localVariableHeaders = mutableMapOf<String, String>()

            val localVariableConfig = RequestConfig<kotlin.Any?>(
            RequestMethod.GET,
            "/store/inventory",
            query = localVariableQuery,
            headers = localVariableHeaders
            )

            return request(
            localVariableConfig,
            localVariableBody,
            localVariableAuthNames
            ).wrap()
            }

        /**
        * Find purchase order by ID
        * For valid response try integer IDs with value &lt;&#x3D; 5 or &gt; 10. Other values will generate exceptions
         * @param orderId ID of pet that needs to be fetched 
         * @return Order
        */
            @Suppress("UNCHECKED_CAST")
        open suspend fun getOrderById(orderId: kotlin.Long): HttpResponse<Order> {

            val localVariableAuthNames = listOf<String>()

            val localVariableBody = 
                    io.ktor.client.utils.EmptyContent

            val localVariableQuery = mutableMapOf<String, List<String>>()

            val localVariableHeaders = mutableMapOf<String, String>()

            val localVariableConfig = RequestConfig<kotlin.Any?>(
            RequestMethod.GET,
            "/store/order/{orderId}".replace("{" + "orderId" + "}", "$orderId"),
            query = localVariableQuery,
            headers = localVariableHeaders
            )

            return request(
            localVariableConfig,
            localVariableBody,
            localVariableAuthNames
            ).wrap()
            }

        /**
        * Place an order for a pet
        * 
         * @param body order placed for purchasing the pet 
         * @return Order
        */
            @Suppress("UNCHECKED_CAST")
        open suspend fun placeOrder(body: Order): HttpResponse<Order> {

            val localVariableAuthNames = listOf<String>()

            val localVariableBody = body

            val localVariableQuery = mutableMapOf<String, List<String>>()

            val localVariableHeaders = mutableMapOf<String, String>()

            val localVariableConfig = RequestConfig<kotlin.Any?>(
            RequestMethod.POST,
            "/store/order",
            query = localVariableQuery,
            headers = localVariableHeaders
            )

            return jsonRequest(
            localVariableConfig,
            localVariableBody,
            localVariableAuthNames
            ).wrap()
            }

        }
