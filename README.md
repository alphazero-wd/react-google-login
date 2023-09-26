# React Google Login 

- In the past, [`react-google-login`](https://www.npmjs.com/package/react-google-login) was used to handle Google authentication. However, it's been deprecated as of 31 March 2023.
- One way to work around this is to implement the latest Google login approach written [here](https://developers.google.com/identity/gsi/web/guides/client-library).
- However, the official article by Google doesn't specify how to integrate directly with a React app. Therefore, I had to do some online research and I came across a [blog post](https://www.dolthub.com/blog/2022-05-04-google-signin-migration/) guiding me on how to achieve that and it worked like a charm.

> NOTE: An alternative to `react-google-login` called [@react-oauth/google](https://www.npmjs.com/package/@react-oauth/google) has finally been released on May 2022 to resolve the issue. Therefore, the approach above might not be as efficient as using an npm package.
