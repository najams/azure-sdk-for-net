// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.ContainerRegistry
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ManifestsOperations.
    /// </summary>
    public static partial class ManifestsOperationsExtensions
    {
            /// <summary>
            /// Get the manifest identified by `name` and `reference` where `reference` can
            /// be a tag or digest.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the image (including the namespace)
            /// </param>
            /// <param name='reference'>
            /// A tag or a digest, pointing to a specific image
            /// </param>
            /// <param name='accept'>
            /// Accept header string delimited by comma. For example,
            /// application/vnd.docker.distribution.manifest.v2+json
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManifestWrapper> GetAsync(this IManifestsOperations operations, string name, string reference, string accept = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(name, reference, accept, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Put the manifest identified by `name` and `reference` where `reference` can
            /// be a tag or digest.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the image (including the namespace)
            /// </param>
            /// <param name='reference'>
            /// A tag or a digest, pointing to a specific image
            /// </param>
            /// <param name='payload'>
            /// Manifest body, can take v1 or v2 values depending on accept header
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> CreateAsync(this IManifestsOperations operations, string name, string reference, Manifest payload, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(name, reference, payload, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete the manifest identified by `name` and `reference`. Note that a
            /// manifest can _only_ be deleted by `digest`.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the image (including the namespace)
            /// </param>
            /// <param name='reference'>
            /// A tag or a digest, pointing to a specific image
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IManifestsOperations operations, string name, string reference, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(name, reference, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List manifests of a repository
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the image (including the namespace)
            /// </param>
            /// <param name='last'>
            /// Query parameter for the last item in previous query. Result set will
            /// include values lexically after last.
            /// </param>
            /// <param name='n'>
            /// query parameter for max number of items
            /// </param>
            /// <param name='orderby'>
            /// orderby query parameter
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AcrManifests> GetListAsync(this IManifestsOperations operations, string name, string last = default(string), int? n = default(int?), string orderby = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetListWithHttpMessagesAsync(name, last, n, orderby, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get manifest attributes
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the image (including the namespace)
            /// </param>
            /// <param name='reference'>
            /// A tag or a digest, pointing to a specific image
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManifestAttributes> GetAttributesAsync(this IManifestsOperations operations, string name, string reference, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAttributesWithHttpMessagesAsync(name, reference, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update attributes of a manifest
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of the image (including the namespace)
            /// </param>
            /// <param name='reference'>
            /// A tag or a digest, pointing to a specific image
            /// </param>
            /// <param name='value'>
            /// Repository attribute value
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAttributesAsync(this IManifestsOperations operations, string name, string reference, ChangeableAttributes value = default(ChangeableAttributes), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateAttributesWithHttpMessagesAsync(name, reference, value, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
