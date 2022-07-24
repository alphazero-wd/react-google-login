import { useStripe } from "@stripe/react-stripe-js";

export const useConfirmSubscriptions = () => {
  const stripe = useStripe();

  const confirmSubscription = async () => {
    const res = await fetch(
      `${process.env.REACT_APP_API_URL}/subscriptions/monthly`,
      {
        method: "GET",
        credentials: "include",
        headers: {
          "Content-Type": "application/json",
        },
      }
    );

    const data = await res.json();
    if (data.status === "incomplete") {
      const secret = data.latest_invoice.payment_intent.client_secret;
      await stripe?.confirmCardPayment(secret);
    }
  };

  return { confirmSubscription };
};
