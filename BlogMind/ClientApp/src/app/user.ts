export interface Address {
    street: string;
    suite: string;
    city: string;
    zipcode: string;
}

export interface User {
    name: string;
    email: string;
    address: Address;
    phone: string;
}
