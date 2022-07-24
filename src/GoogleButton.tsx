import { useEffect, useRef } from "react";

export default function GoogleButton(): JSX.Element {
  const divRef = useRef<HTMLDivElement>(null);

  useEffect(() => {
    if (typeof window === "undefined" || !window.google || !divRef.current) {
      return;
    }

    try {
      window.google.accounts.id.initialize({
        client_id: process.env.REACT_APP_GOOGLE_AUTH_CLIENT_ID as string,
        callback: async (res) => {
          // send access token to the server
          const result = await fetch(
            `${process.env.REACT_APP_API_URL}/google-auth`,
            {
              method: "POST",
              body: JSON.stringify({ token: res.credential }),
              headers: {
                "Content-Type": "application/json",
              },
            }
          );
          console.log("result", await result.json());
        },
      });
      window.google.accounts.id.renderButton(divRef.current, {
        size: "large",
        type: "icon",
        text: "signup_with",
      });
    } catch (error) {
      console.log(error);
    }
  }, [divRef.current]);

  return <div ref={divRef} />;
}
